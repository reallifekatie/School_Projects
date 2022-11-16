<!DOCTYPE html>
<html>
    <body>
    <?php include "./includes/header.php" ?> 


    <!-- Menu Container -->
    <div class="w3-container w3-black w3-padding-64 w3-xxlarge" id="menu">
      <div class="w3-content">

        <h1 class="w3-center w3-jumbo" style="margin-bottom:64px">THE MENU</h1>

        <?php
        echo "<h1> Daily Special: One Starter and One Entree</h1>";
        
        $specialStarter = "Bruschetta";
        $specialEntree = "Seafood Pasta";
        $discountPercent =  .25;
        $starterOriginalPrice = 8.50;
        $entreeOriginalPrice = 25.50;
        $specialOriginalPrice = $starterOriginalPrice + $entreeOriginalPrice;
        $discountAmount = $specialOriginalPrice * $discountPercent;
        $specialDiscountPrice = $specialOriginalPrice - $discountAmount;

        
        echo "<p>Today: $specialStarter and $specialEntree. <br>";
        echo "Discount today: $discountPercent %<br>";
        echo "Original price:$ $specialOriginalPrice<br>";
        echo "Discount price: $ $specialDiscountPrice</p><br>";
        ?>

        <div class="w3-row w3-center w3-border w3-border-dark-grey">
          <a href="javascript:void(0)" onclick="openMenu(event, 'Pizza');" id="myLink">
            <div class="w3-col s4 tablink w3-padding-large w3-hover-red">Pizza</div>
          </a>
          <a href="javascript:void(0)" onclick="openMenu(event, 'Pasta');">
            <div class="w3-col s4 tablink w3-padding-large w3-hover-red">Pasta</div>
          </a>
          <a href="javascript:void(0)" onclick="openMenu(event, 'Starter');">
            <div class="w3-col s4 tablink w3-padding-large w3-hover-red">Starter</div>
          </a>
        </div>

        <!-- container for Pizza category -->
        <div id="Pizza" class="w3-container menu w3-padding-32 w3-white">
          <?php
            $sqlPizza = "SELECT menu_item_name, menu_item_emphasis, menu_item_price, menu_item_description FROM menu WHERE menu_item_category = 'Pizza'";      
            $result = $dbc->query($sqlPizza);
            
            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    echo "<h1><b>{$row['menu_item_name']} <p class='w3-tag w3-red w3-round'> {$row['menu_item_emphasis']}</p></b> <p class='w3-right w3-tag w3-dark-grey w3-round'> $ {$row['menu_item_price']} </p></h1> <p class='w3-text-grey'>{$row['menu_item_description']} </p><hr>";
                }
            }          
          ?>
        </div>

        <!-- container for Pasta category -->
        <div id="Pasta" class="w3-container menu w3-padding-32 w3-white">
          <?php
            $sqlPasta = "SELECT menu_item_name, menu_item_emphasis, menu_item_price, menu_item_description FROM menu WHERE menu_item_category = 'Pasta'";      
            $result = $dbc->query($sqlPasta);
            
            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    echo "<h1><b>{$row['menu_item_name']}</b> <p class='w3-tag w3-grey w3-round'> {$row['menu_item_emphasis']}</p> <p class='w3-right w3-tag w3-dark-grey w3-round'> $ {$row['menu_item_price']} </p></h1> <p class='w3-text-grey'>{$row['menu_item_description']} </p><hr>";
                }
            }          
          ?>
        </div>

        <!-- container for Starter category -->
        <div id="Starter" class="w3-container menu w3-padding-32 w3-white">
          <?php
            $sqlStarter = "SELECT menu_item_name, menu_item_emphasis, menu_item_price, menu_item_description FROM menu WHERE menu_item_category = 'Starter'";      
            $result = $dbc->query($sqlStarter);
            
            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    echo "<h1><b>{$row['menu_item_name']}</b> <p class='w3-tag w3-grey w3-round'> {$row['menu_item_emphasis']}</p> <p class='w3-right w3-tag w3-dark-grey w3-round'> $ {$row['menu_item_price']} </p></h1> <p class='w3-text-grey'>{$row['menu_item_description']} </p><hr>";
                }
            }          
          ?>
        </div><br>

      </div>
    </div>
    <script src="./scripts/pizzascripts.js"></script>
    <?php include "./includes/footer.html" ?> 
    </body>
</html>