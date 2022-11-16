<?php # DISPLAY COMPLETE LOGGED OUT PAGE.

# Access session.
session_start() ;

# Redirect if not logged in.
if ( !isset( $_SESSION[ 'user_id' ] ) ) { require ( 'login_tools.php' ) ; load() ; }

# Set page title and display header section.
$page_title = 'Goodbye' ;
include ( 'includes/header.php' ) ;

# Clear existing variables.
$_SESSION = array() ;
  
# Destroy the session.
session_destroy() ;

# Display body section.
echo '<h1>Bye Felicia!</h1><p><h3>You are now logged out.</p><p><a href="pizza_login.php">Login</a></h3></p>' ;

# Display footer section.
include ( 'includes/footer.html' ) ;

?>