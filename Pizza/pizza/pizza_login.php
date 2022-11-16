<?php # DISPLAY COMPLETE LOGIN PAGE.

# Set page title and display header section.
$page_title = 'Login' ;

include ( 'includes/header.php' ) ;

# Display any error messages if present.
if ( isset( $errors ) && !empty( $errors ) )
{
 echo '<h3><p id="err_msg">Oops! There was a problem:<br>' ;
 foreach ( $errors as $msg ) { echo " - $msg<br>" ; }
 echo 'Please try again or <a href="pizza_register.php">Register</a></p></h3>' ;
}
?>

<!-- Display body section. -->
<h1>Menu Management Login</h1>
<form action="login_action.php" method="post">
<p><h3>Email Address: <input type="text" name="email"> </h3></p>
<p><h3>Password: <input type="password" name="pass"></h3></p>
    
<p><h3><input type="submit" value="Login" ></h3></p>
</form>

<?php 

# Display footer section.
 include ( 'includes/footer.html' ) ; 

?>
