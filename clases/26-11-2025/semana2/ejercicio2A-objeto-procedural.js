// primer ejercicio con three.js
// crear una geometria teniendo en cuenta el orden de los vértices
var camera, scene, renderer;
var cameraControls;
var controlValores;
var clock = new THREE.Clock();
var ambientLight, light;
var miobjeto;
var preX=0;
var preY=0;
var preZ=0;

function rota_objeto()
{
var x=0;
var y=0;
var z=0;
var angulo = 0;
var i=0;
var a = new THREE.Vector3( 0, 0, 0 );
var b = new THREE.Vector3( 0, 0, 0 );
var n = new THREE.Vector3( 0, 0, 0 );
var ind1=0;
var ind2=0;
var mimatriz = new THREE.Matrix4();

if (controlValores.ejeX !== preX)
    {
    angulo = (controlValores.ejeX-preX)/10.0;
    preX = controlValores.ejeX;
    // TODO calcular matriz de rotación respecto a eje X
    // mimatriz.set(/* ... */ );
    x= 1;
    }
   else if (controlValores.ejeY !== preY)
          {
	  angulo = (controlValores.ejeY-preY)/10.0;
          preY = controlValores.ejeY;
	  // TODO calcular matriz de rotación respecto a eje Y
	  // mimatriz.set(/* ... */ );
          y= 1;
          }
        else 
          {
	  angulo = (controlValores.ejeZ-preZ)/10.0;
	  preZ = controlValores.ejeZ;
	  // TODO calcular matriz de rotación respecto a eje Z
          //mimatriz.set( /* ... */ );
          z= 1;
	  };

var mivertice = new THREE.Vector3(0,0,0);

 // TODO calcular las coordenadas de cada vértice y modificarlas en la tabla de vertices del objeto
//     a tener en cuenta: en un motor gráfico no se recalculan las coordenadas de la geometria
//     solo se guardan las matrices tras multiplicar la antigua con la nueva transformación!
/*
for (i=0;i<miobjeto.geometry.vertices.length; i++)
    {
    
    }
*/

 // TODO recalcular las coordenadas de los vectores normales de los poligonos y reasignar
//     a tener en cuenta: en un motor gráfico no se recalculan las coordenadas de la geometria
//     solo se guardan las matrices tras multiplicar la antigua con la nueva transformación!
/*
for (i=0;i<miobjeto.geometry.faces.length; i++)
    {
    // calcular vector normal...

    miobjeto.geometry.faces[i].normal.set(  ...  );
    }
*/

// TODO descomentar las dos siguientes sentencias para que three.js haga lo que deba hacer
//miobjeto.geometry.verticesNeedUpdate=true;
//miobjeto.geometry.normalsNeedUpdate=true;
}

function mueve_objeto(val)
{
var i;

// TODO mover los vértices hacia arriba tanto como dice val (puede ser negativo)
/*
for (i=0;i<miobjeto.geometry.vertices.length; i++)
    {
     ...
    }
*/
// TODO descomentar la siguiente sentencia
miobjeto.geometry.verticesNeedUpdate=true;
}

function setupGUI()
{

controlValores =
    {
    ejeX: 0.0,
    ejeY: 0.0,
    ejeZ: 0.0
    };

var gui = new dat.GUI();

// cambios en el objeto

gui.add( controlValores, "ejeX", 0, 100, 0 ).name( "ejeX" ).onChange( rota_objeto );
gui.add( controlValores, "ejeY", 0, 100, 0 ).name( "ejeY" ).onChange( rota_objeto );
gui.add( controlValores, "ejeZ", 0, 100, 0 ).name( "ejeZ" ).onChange( rota_objeto );
}

function init() {
	var canvasWidth = window.innerWidth * 0.9;
	var canvasHeight = window.innerHeight * 0.9;
	// botones  para interacción up y down
	container = document.createElement('div');
	document.body.appendChild(container);

	var info = document.createElement('div');
	info.style.position = 'absolute';
	info.style.top = '10px';
	info.style.width = '100%';
	info.style.textAlign = 'center';
	info.innerHTML += 'Mover objeto:<input id="Arriba" type="button" onclick="mueve_objeto(0.1)" value="Up"/><input id="abajo" type="button" onclick="mueve_objeto(-0.1)" value="Down"/>';
	container.appendChild(info);

	// CAMERA

	camera = new THREE.PerspectiveCamera( 45, window.innerWidth / window.innerHeight, 1, 80000 );
	camera.position.set(-1,1,3);
	camera.lookAt(0,0,0);

	// LIGHTS

	light = new THREE.DirectionalLight( 0xFFFFFF, 0.7 );
	light.position.set( 1, 1, 1 );
	light.target.position.set(0, 0, 0);
	light.target.updateMatrixWorld()

	var ambientLight = new THREE.AmbientLight( 0x111111 );

	// RENDERER
	renderer = new THREE.WebGLRenderer( { antialias: true } );
	renderer.setSize( canvasWidth, canvasHeight );
	renderer.setClearColor( 0xAAAAAA, 1.0 );

	renderer.gammaInput = true;
	renderer.gammaOutput = true;

	// Add to DOM
	var container = document.getElementById('container');
	container.appendChild( renderer.domElement );

	// CONTROLS
	cameraControls = new THREE.OrbitControls( camera, renderer.domElement );
	cameraControls.target.set(0, 0, 0);

	// OBJECT
	
    
        var migeometria = new THREE.Geometry();
        var miotrageometria = new THREE.Geometry();
	var num_lados = 16;
	var luz = 0.1;
	// en funcion del numero de lados he de saltar tantos radianes
	var salto = Math.PI * 2 /num_lados; 
	var a = new THREE.Vector3( 0, 0, 0 );
	var b = new THREE.Vector3( 0, 0, 0 );
	var n = new THREE.Vector3( 0, 0, 0 );
	var indplustwo=0.0;

	// TODO generar la tabla de vértices: el número depende de num_lados!
	for (i=0; i<num_lados; i++)
		{
		/* ... una o varias veces  migeometria.vertices.push (...) */
		}
	// TODO generar la tabla de polígonos y asignar a cada poígono el vector normal que le corresponde
	//  el numero de poligonos depende de num_lados
	for (i=0; i<(num_lados); i++)
		{
		/* ...una o varias veces  migeometria.faces.push (...)  */
		}
	
    var material = new THREE.MeshPhongMaterial( { color: 0xFF0000 } ); // Material de color rojo
    // TODO tras generar la geometria hay que generar la malla junto con el material
    // descomentar la sentencia:
    //miobjeto = new THREE.Mesh (migeometria, material); // Crea el objeto

    miotrageometria= new THREE.SphereGeometry( 0.7, 64, 64 ); //BoxGeometry( 1, 1, 1 );
    var miotroobjeto = new THREE.Mesh (miotrageometria, material); 
	
	// SCENE

	scene = new THREE.Scene();
	scene.add( light );
	scene.add( ambientLight );

	scene.add( miobjeto );
	scene.add( miotroobjeto );
        setupGUI();

}

function animate() {
	window.requestAnimationFrame( animate );
	render();
}

function render() {
	var delta = clock.getDelta();
	cameraControls.update(delta);
	renderer.render( scene, camera );
}

try {
	init();
	animate();
} catch(e) {
	var errorReport = "Your program encountered an unrecoverable error, can not draw on canvas. Error was:<br/><br/>";
	$('#container').append(errorReport+e);
}
