function showLogin(){    
    

    if (document.getElementById("loginPage").style.display === "block"){
        document.getElementById("loginPage").style.display = "none"
    }
    else{
        document.getElementById("loginPage").style.display = "block"
        document.getElementById("registerPage").style.display = "none"
    }
}

function showRegister(){
   
   
  

    if (document.getElementById("registerPage").style.display === "block"){
        document.getElementById("registerPage").style.display = "none"
    }
    else{
        document.getElementById("loginPage").style.display = "none"
        document.getElementById("registerPage").style.display = "block"
    }
    console.log(5)
}