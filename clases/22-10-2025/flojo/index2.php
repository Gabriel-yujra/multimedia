<?php
if (isset($_GET["proceso"]))
	$proceso="P2";
else 
	$proceso="P1";
?>
<html>
	<body>
		<form method="get" action="motor.php">
			Hola mundo
			<input type="hidden" name="proceso" value="<?php echo $proceso;?>">
			<?php
			if ($proceso=="P2")
			{
				include "proceso2.php";

			}	
			else
			{
				include "pantalla.php";
			}
			
			?>
			<br>
			<input type="submit" value="Anterior" name="Anterior">
			<input type="submit" value="Siguiente" name="Siguiente">
		</form>
	</body>
</html>