<html>
<body>
	Hola mundo
	<?php
	echo "que tal metal";
	$codflujo=$_GET["codflujo"];
	$codproceso=$_GET["codproceso"];
	$conexion=mysqli_connect("localhost","root","","wflujo");
	$ejecucion = mysqli_query($conexion, "select * from flujo where codflujo='$codflujo' and codproceso='$codproceso'");
	$fila=mysqli_fetch_assoc($ejecucion);
	$pantalla=$fila["pantalla"].".inc.php";
	?>
	<!--iframe src="pantalla.php"></iframe-->

	<?php
	include $pantalla;
	?>
</body>
</html>