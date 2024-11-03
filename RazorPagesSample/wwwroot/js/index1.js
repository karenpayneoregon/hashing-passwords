document.addEventListener("DOMContentLoaded",
    () => {
        document.getElementById("pWord").type = "password";
    });

/*
 * toggle visibility of password input
 */
document.getElementById("passwordToggle").addEventListener("click",
    function () {
        var x = document.getElementById("pWord");
        if (x.type === "password") {
            x.type = "text";
        } else {
            x.type = "password";
        }
    });