<?php
include "conexion.inc.php";
$cod_flujo=$_GET["cod_flujo"];
$cod_proceso=$_GET["cod_proceso"];
$sql="SELECT * FROM flujo ";
$sql.="where codflujo='$cod_flujo' and codproceso='$cod_proceso'";
$resultado=mysqli_query($con, $sql);
$fila = mysqli_fetch_array($resultado);
$pantalla=$fila["pantalla"];
?>
<form action="procesar.php" method="GET">
	<?php include $pantalla.".inc.php"; ?>
	<input type="hidden" name="cod_flujo" value="<?php echo $cod_flujo;?>">
	<input type="hidden" name="cod_proceso" value="<?php echo $cod_proceso;?>">
	<br>
	<input type="submit" value="Anterior" name="Anterior"/>
	<input type="submit" value="Siguiente" name="Siguiente"/>
</form>