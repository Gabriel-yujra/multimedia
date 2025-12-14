<?php
session_start();
$_SESSION["usuario"]="jperez";
$_SESSION["idusuario"]=45;
include "conexion.inc.php";
$sql="SELECT * FROM seguimiento where fechafinal is null and usuario='".$_SESSION["usuario"]."' ";
$resultado=mysqli_query($con, $sql);
?>
<table>
	<tr>
		<td>Flujo</td>
		<td>Proceso</td>
		<td>Operaciones</td>
	<tr>
<?php
while ($fila = mysqli_fetch_array($resultado))
{
	echo "<tr>";
	echo "<td>$fila[flujo]</td>";
	echo "<td>$fila[proceso]</td>";
	echo "<td><a href='http://localhost:8080/flujop/motor.php?cod_flujo=$fila[flujo]&cod_proceso=$fila[proceso]'>Ver</a></td>";
	echo "<tr>";
}
?>
</table>