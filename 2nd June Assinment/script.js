function handleLogin(event) {
    event.preventDefault();
    const usernameInput = document.getElementById("username");
    const passwordInput = document.getElementById("password");
    const username = usernameInput.value.trim();
    const password = passwordInput.value.trim();

    if (!username || !password) {
        displayError("Please enter both username and password.");
        return;
    }

    if (username === "Arpit" && password === "arpitmnmnm") {
        window.location.href = "dashboard.html";
    } else {
        displayError("Invalid username or password.");
    }
}

function displayError(message) {
    const errorElement = document.getElementById("error-message");
    errorElement.textContent = message;
    errorElement.style.display = "block";
}
