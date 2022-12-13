<?php # DISPLAY CHECKOUT PAGE.

# Access session.
session_start() ;

 

# Set page title and display header section.
$page_title = 'Checkout' ;
include ( 'includes/header.php' ) ; ?>
<div class="w3-main" style="margin-left:250px">

  <!-- Push down content on small screens -->
  <div class="w3-hide-large" style="margin-top:83px"></div>
  
  <!-- Top header -->
  <header class="w3-container w3-xlarge">
    <p class="w3-left">Jeans</p>
    <p class="w3-right">
      <button id="viewCartButton" class="fa fa-shopping-cart w3-margin-right"></button>
      <!--<i class="fa fa-shopping-cart w3-margin-right"></i>-->
      <i class="fa fa-search"></i>
    </p>
  </header>
  <script type="text/javascript">
    document.getElementById("viewCartButton").onclick = function () {
        location.href = "./JeansCart.php";
    };
  </script>
    
    

  <!-- Image header -->
  <div class="w3-display-container w3-container">
    <img src="https://www.w3schools.com//w3images/jeans.jpg" alt="Jeans" style="width:100%">
    <div class="w3-display-topleft w3-text-white" style="padding:24px 48px">
      <h1 class="w3-jumbo w3-hide-small">New arrivals</h1>
      <h1 class="w3-hide-large w3-hide-medium">New arrivals</h1>
      <h1 class="w3-hide-small">COLLECTION 2021</h1>
      <p><a href="./Jeans.php" class="w3-button w3-black w3-padding-large w3-large">SHOP NOW</a></p>
    </div>
  </div>



<div class="w3-display-container w3-container">
  <div class="w3-container w3-text-grey" id="jeans">
      <! --- 
     *******************************************
     IMPLEMENT YOUR PHP HERE
     
     ---->
    </div>
</div>
<?php
# Display footer section.
include ( 'includes/footer.php' ) ; 

?>