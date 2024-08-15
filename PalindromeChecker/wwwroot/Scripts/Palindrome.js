document.getElementById('checkForm').addEventListener('submit', async function (e) {
    e.preventDefault();
    var number = document.getElementById('txtNumberInput').value;
    var output;
    try {
        var response = await fetch(`/Palindrome/PalindromeCheck?number=${number}`);
        var result = await response.json();
        output = result.isPalindrome ? `${result.number} is a palindrome.` : `${result.number} is not a palindrome.`;
    } catch (err) {
        output = "Please input positive numbers only.";
    }
    
    document.getElementById('result').innerText = output;
});