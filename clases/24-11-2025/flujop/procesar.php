<?php
include "conexion.inc.php";

if (isset($_GET["Siguiente"]))
{
$cod_flujo=$_GET["cod_flujo"];
$cod_proceso=$_GET["cod_proceso"];

$sql="SELECT * FROM flujo ";
$sql.="where codflujo='$cod_flujo' and codproceso='$cod_proceso'";
$resultado=mysqli_query($con, $sql);
$fila = mysqli_fetch_array($resultado);
$proceso=$fila["cod_procesosiguiente"];
}
else 
{
$cod_flujo=$_GET["cod_flujo"];
$cod_proceso=$_GET["cod_proceso"];

$sql="SELECT * FROM flujo ";
$sql.="where codflujo='$cod_flujo' and cod_procesosiguiente='$cod_proceso'";
$resultado=mysqli_query($con, $sql);
$fila = mysqli_fetch_array($resultado);
$proceso=$fila["codproceso"];
}

header("Location: motor.php?cod_flujo=$cod_flujo&cod_proceso=$proceso");


?>