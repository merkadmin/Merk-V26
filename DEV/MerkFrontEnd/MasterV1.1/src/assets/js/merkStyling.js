$(function () {
  var promise = document.querySelector("#btnSaveChanges");
  if (promise !== undefined && promise !== null) {
    promise.addEventListener("click", function () {
      Lobibox.notify("success", {
        size: "mini",
        closeOnClick: true,
        sound: true,
        icon: true,
        position: "top right",
        img: "./assets/images/successicon.png",
        title: "Done",
        msg: "Saved Succeffully ... !",
      });
    });
  }
});

