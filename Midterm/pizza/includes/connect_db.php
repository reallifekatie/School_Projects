<?php
echo 'in php file';
$dbc = mysqli_connect('localhost', 'katiesmith', 'cnit2648', 'pizza')
OR die
 (mysqli_connect_error());

mysqli_set_charset($dbc, 'utf8');
if (mysqli_ping($dbc))
{ 
    echo 'MySQL Server'.mysqli_get_server_info($dbc).'connected on'.mysqli_get_host_info($dbc);

}
?>