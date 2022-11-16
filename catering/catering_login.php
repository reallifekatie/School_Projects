<?php # DISPLAY COMPLETE LOGIN PAGE.

# Set page title and display header section.
$page_title = 'Login' ;

include ( 'includes/catering_header.php' ) ;

# Display any error messages if present.
if ( isset( $errors ) && !empty( $errors ) )
{
 echo '<p id="err_msg">Oops! There was a problem:<br>' ;
 foreach ( $errors as $msg ) { echo " - $msg<br>" ; }
 echo 'Please try again or <a href="catering_register.php">Register</a></p>' ;
}
?>

<!-- Display body section. -->
<h1>Menu Management Login</h1>
<form action="login_action.php" method="post">
<p>Email Address: <input type="text" name="email"> </p>
<p>Password: <input type="password" name="pass"></p>
    
<p><input type="submit" value="Login" ></p>
</form>

<?php 

# Display footer section.
 include ( 'includes/catering_footer.php' ) ; 

?>
