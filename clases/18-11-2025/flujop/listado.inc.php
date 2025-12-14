listado
<?php
include "conexion.inc.php";
$sql="select * from academico.alumno where ci=45";
$resultado=mysqli_query($con, $sql);
$fila = mysqli_fetch_array($resultado);
$ci=$fila["ci"];
$nombre=$fila["nombre"];
$paterno=$fila["paterno"];
?>
<label>CI</label>
<input type="text" name="ci" value="<?php echo $ci;?>">
<br>
<label>Nombre</label>
<input type="text" name="nombre" value="<?php echo $nombre;?>">
<br>
<label>Paterno</label>
<input type="text" name="paterno" value="<?php echo $paterno;?>">