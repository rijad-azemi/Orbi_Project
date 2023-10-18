
document.addEventListener("DOMContentLoaded", (event) => {
    document.getElementById("randomizeButton").addEventListener("click", function () {

        fetch("/Home/GetRandomDish")
            .then(response => response.json())
            .then(data => {
                if (data) {
                    document.getElementById("randomDishName").textContent = data.dishName;
                    document.getElementById("randomRestaurantName").textContent = data.restaurantName;
                }
            });
    });
})
