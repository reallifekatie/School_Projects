<?php # LOGIN HELPER FUNCTIONS.

# Function to load specified or default URL.
function load( $page = 'login.php' )
{
    echo "in load";
  # Begin URL with protocol, domain, and current directory.
  $url = 'http://' . $_SERVER[ 'HTTP_HOST' ] . dirname( $_SERVER[ 'PHP_SELF' ] ) ;

  # Remove trailing slashes then append page name to URL.
  $url = rtrim( $url, '/\\' ) ;
  $url .= '/' . $page ;

  # Execute redirect then quit. 
  header( "Location: $url" ) ; 
  exit() ;
}

# Function to check email address and password. 
function validate( $dbc, $email = '', $pwd = '')
{
  # Initialize errors array.
  $errors = array() ; 
  echo "in validate";
  # Check email field.
  if ( empty( $email ) ) 
  { $errors[] = 'Enter your email address.' ; } 
  else  { $e = mysqli_real_escape_string( $dbc, trim( $email ) ) ; }

  # Check password field.
  if ( empty( $pwd ) ) 
  { $errors[] = 'Enter your password.' ; } 
  else { $p = mysqli_real_escape_string( $dbc, trim( $pwd ) ) ; }

  # On success retrieve user_id, first_name, and last name from 'users' database.
  if ( empty( $errors ) ) 
  {
      echo " in check";
    $q = "SELECT user_id, first_name, last_name FROM site_db.users WHERE email='$e' AND pass='1111'" ;  
      
      echo $q;
      echo "<br>";
      echo $p;
      echo "<br>";
    $r = mysqli_query ( $dbc, $q ) ;
      
     var_dump($r);
      
      
    if ( @mysqli_num_rows( $r ) == 1 ) 
    {
      $row = mysqli_fetch_array ( $r, MYSQLI_ASSOC ) ;
      return array( true, $row ) ; 
    }
    # Or on failure set error message.
    else { $errors[] = 'Email address and password not found.' ; }
  }
  # On failure retrieve error message/s.
  return array( false, $errors ) ; 
}