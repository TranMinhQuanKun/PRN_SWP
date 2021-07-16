﻿window.onload = function () {
    var xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
            console.log(this.responseText);
            const selectOptions = JSON.parse(this.responseText);
            processCategory(selectOptions);       
    };
    xhttp.open("GET", "GetCategoryList", false);
    xhttp.send();
    getPendingList();
    getProduct();
};

function processCategory(data) {
    var defaultOps = document.createElement("option");
    defaultOps.setAttribute("value", "all");
    defaultOps.innerHTML = "(*)";
    document.getElementById("inputGroupSelect01").appendChild(defaultOps);
    for (i = 0; i < data.length; i++) {
        var selectOps = document.createElement("option");
        selectOps.setAttribute("value", i + 2);
        selectOps.innerHTML = data[i].name;
        document.getElementById("inputGroupSelect01").appendChild(selectOps);
    }
}

let productObject;
let notification;
let tempThreshold;
let pendingList;

function getProduct() {
    productObject = null;
    var xhttp = new XMLHttpRequest();
    var cat_ID = document.getElementById("inputGroupSelect01").value;
    var search_val = document.getElementById("inputSearchVal").value;
    var noos = document.getElementById("noos_check");
    xhttp.onload = function () {
        console.log(JSON.parse(this.responseText));
        productObject = JSON.parse(this.responseText);
        printProductList(productObject);
    };

    if (noos.checked == true) {
        if (cat_ID === "all") {
            var url =
                "GetProductList?search_value=" + search_val +
                "&only_noos_items=true";
        } else {
            var url =
                "GetProductList?search_value=" +
                search_val +
                "&category_id=" +
                cat_ID +
                "&only_noos_items=true";
        }
    } else {
        if (cat_ID === "all") {
            var url = "GetProductList?search_value=" + search_val;
        } else {
            var url =
                "GetProductList?search_value=" + search_val +
                "&category_id=" + cat_ID;
        }
    }
    xhttp.open("GET", url, false);
    xhttp.send();
}

function getPendingList() {
    var xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
        console.log(this.responseText);
        pendingList = JSON.parse(this.responseText);
    };
    xhttp.open("GET", "GetPendingItemList", false);
    xhttp.send();
};

function printProductList(data) {
    document.getElementById("tableContent").innerHTML = "";
    var index = 0;
    for (i = 0; i < data.length; i++) {
        if (data[i].is_selling !== false) {
            index++;
            var tr = document.createElement("tr");

            var th_index = document.createElement("th");
            th_index.setAttribute("scope", "row");
            th_index.innerHTML = index;
            th_index.style.textAlign = "right";

            var td_name = document.createElement("td");
            td_name.innerHTML = data[i].name;
            td_name.style.textAlign = "left";

            var td_category = document.createElement("td");
            td_category.innerHTML = data[i].category.name;

            var td_threshold = document.createElement("td");
            td_threshold.innerHTML = data[i].lower_threshold;
            td_threshold.setAttribute("class", "text-right");
            td_threshold.setAttribute("id", "thresholdOf" + data[i].product_ID);

            var td_quantity = document.createElement("td");
            td_quantity.setAttribute("class", "text-right");
            td_quantity.innerHTML = data[i].quantity;

            if (data[i].lower_threshold >= data[i].quantity) {
                tr.className = "red-row";
            }

            var td_button = document.createElement("td");
            var Add_bt = document.createElement("a");


            if (pendingList !== null) {
                const foundInPending = Boolean(pendingList.filter(item => item.product_ID === data[i].product_ID).length);

                if (foundInPending === false) {
                    Add_bt.innerHTML = "<i class='far fa-share-square btn-inventory mr-2' style='cursor: pointer;'></i>";
                    Add_bt.setAttribute("onclick", "addToPendingListByOwner(" + data[i].product_ID + ")");
                } else {
                    Add_bt.innerHTML = "<i class='far fa-share-square btn-inventory mr-2' style='opacity: 0.2; cursor: not-allowed;'></i>";
                }
            } else {
                Add_bt.innerHTML = "<i class='fas fa-plus-circle btn-inventory mr-2'></i>";
                Add_bt.setAttribute("onclick", "addToPendingListByOwner(" + data[i].product_ID + ")");
            }
            
            var Edit_bt = document.createElement("a");
            Edit_bt.innerHTML = "<i class='fas fa-ellipsis-h btn-inventory'></i>";
            Edit_bt.setAttribute("data-toggle", "modal");
            Edit_bt.setAttribute("data-target", "#editModal");
            Edit_bt.setAttribute("onclick", "setUpModal(" + data[i].product_ID + ")");
            td_button.setAttribute("class", "btn-col");
            td_button.appendChild(Add_bt);
            td_button.appendChild(Edit_bt);

            tr.appendChild(th_index);
            tr.appendChild(td_name);
            tr.appendChild(td_category);
            tr.appendChild(td_threshold);
            tr.appendChild(td_quantity);
            tr.appendChild(td_button);

            document.getElementById("tableContent").appendChild(tr);
        }
    } 
}

function addToPendingListByOwner(productID) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState >= 4 && this.status <= 200) {
            console.log(this.responseText);
            notification = JSON.parse(this.responseText);
            if (notification == "1") {
                $('#success-to-save-toast').toast({
                    delay: 3000
                });
                $('#success-to-save-toast').toast('show');
            }
        }
    };
    var product_ID = encodeURIComponent(productID);
    var noti_mess = encodeURIComponent("owner");
    var JSONObject = {
        product_ID: product_ID,
        noti_mess: noti_mess
    };
    xhttp.open("POST", "AddToSuggestion", false);
    xhttp.setRequestHeader('Content-type', 'application/json');
    xhttp.setRequestHeader('Accept', 'application/json');
    xhttp.send(JSON.stringify(JSONObject));
    getPendingList();
    getProduct();
}


function addToPendingListAuto(productID) {
    var xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
            console.log(this.responseText);
            notification = JSON.parse(this.responseText);
            if (notification == "1") {
                $('#success-auto-save-toast').toast({
                    delay: 3000
                });
                $('#success-auto-save-toast').toast('show');
            }
    };
    var product_ID = encodeURIComponent(productID);
    var noti_mess = encodeURIComponent("auto");
    var JSONObject = {
        product_ID: product_ID,
        noti_mess: noti_mess
    };
    xhttp.open("POST", "AddToSuggestion", false);
    xhttp.setRequestHeader('Content-type', 'application/json');
    xhttp.setRequestHeader('Accept', 'application/json');
    xhttp.send(JSON.stringify(JSONObject));
    getPendingList();
    getProduct();
}

function setUpModal(productID) {
    for (i = 0; i < productObject.length; i++) {
        if (productObject[i].product_ID == productID) {
            document
                .getElementById("productname")
                .setAttribute("value", productObject[i].name);
            document
                .getElementById("product-oldquantity")
                .setAttribute("value", productObject[i].quantity);
            document
                .getElementById("hiddenProductID")
                .setAttribute("value", productObject[i].product_ID);
            break;
        }
    }
}

function changeStatusInPendingListIfHas(productID) {
    var xhttp = new XMLHttpRequest();

    var product_ID = encodeURIComponent(productID);
    var JSONObject = {
        product_ID: product_ID
    };
    xhttp.open("POST", "UpdateSuggestion", false);
    xhttp.setRequestHeader('Content-type', 'application/json');
    xhttp.setRequestHeader('Accept', 'application/json');
    xhttp.send(JSON.stringify(JSONObject));
}

function updateQuantity() {
    var xhttp = new XMLHttpRequest();
    var productID = document.getElementById("hiddenProductID").value;
    var newquantity = document.getElementById("product-newquantity").value;
    if (newquantity != "" && newquantity >= 0) {
        for (i = 0; i < productObject.length; i++) {
            if (productObject[i].product_ID == productID) {
                tempThreshold = productObject[i].lower_threshold;
                break;
            }
        }
        if (tempThreshold >= newquantity) {
            addToPendingListAuto(productID);
        } else {
            changeStatusInPendingListIfHas(productID);
        }
        var product_ID = encodeURIComponent(productID);
        var new_quantity = encodeURIComponent(newquantity);
        var JSONObject = {
            product_ID: product_ID,
            new_quantity: new_quantity
        };
        xhttp.open("POST", "UpdateQuantity", false);
        xhttp.setRequestHeader('Content-type', 'application/json');
        xhttp.setRequestHeader('Accept', 'application/json');
        xhttp.send(JSON.stringify(JSONObject));
        document.getElementById("product-newquantity").value = "";
        $("#editModal").modal("hide");
        getPendingList();
        getProduct();
    } else {
        alert("Hãy điền số lượng phù hợp");
    }
}
