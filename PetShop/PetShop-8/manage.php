<!DOCTYPE html>
<html>
   
<body>
 <?php include "./includes/header.php" ?>


<!-- About Container -->
<div class="w3-container w3-padding-64 w3-red w3-grayscale w3-xlarge" id="about">
  <?php
    
    
                # Access session.
                session_start() ; 

                # Redirect if not logged in.
                if ( !isset( $_SESSION[ 'user_id' ] ) ) { require ( 'login_tools.php' ) ; load() ; }

                # Display body section.
                echo "<p>You are now logged in, {$_SESSION['user_fname']} {$_SESSION['user_lname']} </p>";
    
                if ($dbc->connect_error) {
                    die("Connection failed: " . $dbc->connect_error);
                }
    
                // update blurb
                if (isset($_POST['update'])) {
                    $old_header = $_POST['old_header'];
                    $new_blurb = $_POST['new_blurb'];
                    $sqlUpdate = "UPDATE petshop.petguide SET petguide_blurb = '$new_blurb' WHERE petguide_header = '$old_header'";
                    if ($dbc->query($sqlUpdate) === TRUE) {
                        echo "Blurb has been updated.";
                    } else {
                        echo "Error: " . $sqlUpdate . "<br>" . $dbc->error;
                    }
                }  
    
                // delete entry
                if (isset($_POST['delete'])) {
                    $header = $_POST['old_header'];
                    $blurb = $_POST['blurb'];
                    $sqlDelete = "DELETE FROM petshop.petguide WHERE petguide_header = '$header'";
                    if ($dbc->query($sqlDelete) === TRUE) {
                        echo "Entry has been successfully removed from the PetGuide.<br>";
                    } else {
                        echo "Error: " . $sqlDelete . "<br>" . $dbc->error;
                    }
                }    
               ?>
</div>

<center><div>
            
          <!-- forms to manage the menu with Add, Update, & Delete -->
            
          <h1 class="w3-center">Manage PetGuide</h1><br>
          <hr> 
          <h2>Update Blurb: </h2>
          <h4><form border="1" action = "" method = "post">
            Header of Blurb to Update: <input type="text" id="old_header" name="old_header" /><br>
            New Blurb: <input type="text" id="new_blurb" name="new_blurb" /><br>
            <input name="update" type="submit" value="Update Blurb">
          </form></h4>
          <hr>
          
          <h2>Delete Entry: </h2>
          <h4><form border="1" action = "" method = "post">
            Header of Entry to Delete: <input type="text" id="old_header" name="old_header" /><br>
            <input name="delete" type="submit" value="Delete Entry"><br>
          </form></h4>
          <hr>
    
    <?php echo '<h1><a href="goodbye.php">Logout</a></h1>' ?>
            
</div></center>
    
</body>
</html>

