using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewerSwitch : MonoBehaviour {

	public Image ImageExtend; //Aquí debería ir el panel al que asignaremos la imagen
	public Image ImageExtend2; //Aquí va el objeto que contendra la imagen pantalla completa
	public Text txt; //Aqui el texto del evento
	public Text title; //aqui el titulo del evento
	public Text date; //aqui la fecha del evento
	public ScrollRect myScrollRect;

	//sub paneles
	public Image panel1;
	public Image panel2;
	public Image panel3;
	public Image panel4;

	bool subPanel = false;
	string siglo;
	string subPanel1;
	string subPanel2;
	string subPanel3;
	string subPanel4;


	public void viewerON(Image viewer) //como parámetro pasamos el panel que activaremos
	{
		viewer.gameObject.SetActive(true);
		myScrollRect.verticalNormalizedPosition = 1.0f;
	}

	public void viewerOFF(Image viewer) //como parámetro pasamos el panel que desactivaremos
	{
		viewer.gameObject.SetActive(false);
	}

	public void loadImage(string name)
	{
		ImageExtend.sprite = Resources.Load<Sprite>("Images/" + name) as Sprite;
		ImageExtend2.sprite = Resources.Load<Sprite>("Images/" + name) as Sprite;
	}

	public void loadImageSubPanel(string choice)
	{
		if(choice == "uno")
		{
			ImageExtend.sprite = Resources.Load<Sprite>("Images/" + subPanel1) as Sprite;
			ImageExtend2.sprite = Resources.Load<Sprite>("Images/" + subPanel1) as Sprite;
		}
		else if(choice == "dos")
		{
			ImageExtend.sprite = Resources.Load<Sprite>("Images/" + subPanel2) as Sprite;
			ImageExtend2.sprite = Resources.Load<Sprite>("Images/" + subPanel2) as Sprite;
		}
		else if(choice == "tres")
		{
			ImageExtend.sprite = Resources.Load<Sprite>("Images/" + subPanel3) as Sprite;
			ImageExtend2.sprite = Resources.Load<Sprite>("Images/" + subPanel3) as Sprite;
		}
		else if (choice == "cuatro")
		{
			ImageExtend.sprite = Resources.Load<Sprite>("Images/" + subPanel4) as Sprite;
			ImageExtend2.sprite = Resources.Load<Sprite>("Images/" + subPanel4) as Sprite;
		}
	}

	public void loadTxt(int number) //carga datos a la linea del tiempo
	{
		if(number == 1700)
		{
            date.text = "1700";

			title.text = "El rey Felipe sube al trono";

			title.fontSize = 40;

			txt.text = "El 16 de noviembre el duque de Anjou, Felipe de Borbón, es proclamado rey, "
			+ "convirtiéndose en el primer rey de la Casa de Borbón del reino español. "
			+ "Carlos IV fue también Rey de la Casa de Borbón.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 17002)
		{
            date.text = "1700";

			title.text = "Inicio de la Dinastía Borbón";

			title.fontSize = 40;

			txt.text = "A la muerte sin descendencia de Fernando VI, le sucedió en el trono su sobrino "
			+ "Carlos III y posteriormente en 1760 es coronado Carlos IV de España,  abdicando éste a "
			+ "favor de su hijo Fernando VII en 1808.";

			subPanel = false;
		}
		else if(number == 1752)
		{
			date.text = "1752";

			title.text = "Nacimiento del obispo Cabañas";

			title.fontSize = 40;

			txt.text = "El 3 de mayo nace en Navarra, España, Juan Cruz Ruiz de Cabañas y Crespo, "
			+ "futuro  Obispo de la Diócesis de Guadalajara de 1795 a 1824.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1757)
		{
			date.text = "1757";

			title.text = "Nacimiento de Manuel Tolsá";

			title.fontSize = 40;

			txt.text = "El 4 de mayo nace en Enguera, Valencia, Don Manuel Vicente Agustín Tolsá y Sarrión, "
			+ "reconocido arquitecto y escultor, quien fue el iniciador del estilo neoclásico en la Nueva España "
			+ "y diseñó La Casa de la Misericordia, actualmente Instituto Cultural Cabañas.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1763)
		{
			date.text = "1763";

			title.text = "Donación del terreno";

			title.fontSize = 40;

			txt.text = "El Dr. Manuel Manzano y Oro entrega al Santuario de Nuestra Señora de la Soledad, parte de sus propiedades "
			+ "localizadas a un costado del río San Juan de Dios con la intención de que se edifique un hospicio para ser administrado "
			+ "por la Iglesia.";

			subPanel = false;
		}
		else if(number == 1767)
		{
			date.text = "1767";

			title.text = "Herencia de fortuna ";

			title.fontSize = 40;

			txt.text = "El acaudalado catalán José Llorens Comelles lega toda su fortuna para la  construcción de un hospital "
			+ "y una casa de asistencia de niños expósitos bajo la advocación de San José, cuya dirección debía quedar bajo el "
			+ "gobierno del obispado. Dicha sucesión ocasiona grandes conflictos legales entre los albaceas, la iglesia y el gobierno.";

			subPanel = false;
		}
		else if(number == 1772)
		{
			date.text = "1772";

			title.text = "Nacimiento de José Gutiérrez López";

			txt.text = "Nace en Macharaviaya, municipio de Málaga, José Gutiérrez López, arquitecto y académico de mérito de la Real Academia "
			+ "de San Carlos y primer maestro de arquitectura en la Nueva Galicia. Se hace cargo de la construcción de La Casa de la "
			+ "Misericordia, actualmente Instituto Cultural Cabañas.";

			title.fontSize = 40;

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1781)
		{
			date.text = "1781";

			title.text = "La Real Academia de San Carlos de la Nueva España";

			title.fontSize = 40;

			txt.text = "El 4 de noviembre el  Rey Carlos III funda la Real Academia de San Carlos de las Tres Nobles Artes en la "
			+ "Nueva España, la primera academia fundada en América. Tomando el modelo de la Academia de las Nobles Artes de San "
			+ "Fernando en Madrid, se dieron las clases de arquitectura, pintura y escultura. Para ello son invitados un grupo de "
			+ "reconocidos artistas españoles –entre los que figuraba Manuel Tolsá- para impartir cátedra, tomando como referencia "
			+ "los modelos franceses, ingleses y españoles de la época. El florecimiento de la  Academia se dio entre los siglos "
			+ "XVIII y XIX y fue el origen de casi toda la pintura, la escultura y dibujo que se produjo en México y Centroamérica "
			+ "en ese momento.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
        }
		else if(number == 1786)
		{
			date.text = "1786";

			title.text = "Sequía en la Nueva Galicia";

			title.fontSize = 40;

			txt.text = "Una gran sequía y desabasto de granos azota la capital del virreinato neogallego;"
			+ " la hambruna toca las puertas de la ciudad y causa la muerte de muchos pobladores.\n\n"
			+ "Lo que más adelante motiva al Obispo Cabañas a edificar un lugar que albergará a viudas y huérfanos.";

			subPanel = false;
		}
		else if(number == 1787)
		{
			date.text = "1787";

			title.text = "El Hospital San Miguel de Belén";

			title.fontSize = 40;

			txt.text = "Ante una epidemia de cólera, Fray Antonio Alcalde inicia un proyecto para “airear” la ciudad, "
			+ "proyectando hacia el norte el Santuario de la Virgen de Guadalupe y la construcción del Hospital Real de "
			+ "San Miguel de Belén, hoy Hospital Civil.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
		}
		else if(number == 1789)
		{
			date.text = "1789";

			title.text = "La revolución francesa";

			title.fontSize = 40;

			txt.text = "El 14 de julio estalla la Revolución francesa con la toma de la Bastilla. El 26 de agosto se aprueba "
			+ "la Declaración de los derechos del hombre y del ciudadano en París.";

			subPanel = false;
		}
		else if(number == 1791)
		{
			date.text = "1791";

			title.text = "Manuel Tolsá llega  a la Nueva España";

			title.fontSize = 40;

			txt.text = "Arriba Manuel Tolsá a la Ciudad de México para hacerse cargo de la dirección de escultura de la "
			+ "Real Academia de San Carlos.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
		}
		else if(number == 1792)
		{
			date.text = "1792";

			title.text = "La Real Universidad de Guadalajara";

			title.fontSize = 40;

			txt.text = "El 7 de agosto, fallece el obispo Fray Antonio Alcalde y Barriga, quien dejó grandes beneficios "
			+ "a la ciudad de Guadalajara, como la construcción del Hospital San Miguel de Belén (hoy Antiguo Hospital Civil), "
			+ "el Santuario de Guadalupe, la Real Universidad de Guadalajara y un sinfín de obras de beneficencia para los más "
			+ "necesitados. El 3 de noviembre, se inaugura la Real Universidad de Guadalajara, la segunda universidad de la "
			+ "Nueva España. Adopta el modelo de la Universidad de Salamanca (en ese momento, referente europeo de educación "
			+ "universitaria) e inicia con las cátedras de medicina, derecho, teología y filosofía, con sede en el Antiguo Colegio "
			+ "de Santo Tomás que había quedado deshabilitado tras la expulsión de la orden de la Compañía de Jesús.";

			subPanel = false;
		}
		else if(number == 17922)
		{
			date.text = "1792";

			title.text = "La primera imprenta en Guadalajara";

			title.fontSize = 40;

			txt.text = "Con el decreto del 7 de febrero de 1792, que le había otorgado la Real Audiencia de Guadalajara, "
			+ "Mariano Valdés, hijo de don Manuel Antonio Valdés, impresor en la Ciudad de México, establece la primera imprenta "
			+ "en Guadalajara.";

			subPanel = false;
		}
		else if(number == 1796)
		{
			date.text = "1796";

			title.text = "El Obispo Cabañas arriba a la Nueva Galicia";

			title.fontSize = 40;

			txt.text = "Después de casi un año de su llegada a Veracruz, el Obispo Juan Cruz Ruiz de Cabañas y Crespo arriba a "
			+ "Guadalajara para hacerse cargo de la diócesis. Desde su recibimiento, el Obispo se da cuenta del hambre y la miseria "
			+ "que existen en un gran sector de la población. Solicita autorización a España para erigir un edificio para alojar a los "
			+ "desamparados, alimentar a los hambrientos y priorizar la enseñanza para quienes la necesitan. Mediante Cédula Real, "
			+ "Carlos IV aprueba que el Obispo Cabañas funde una casa de expósitos y que elija el terreno para su construcción.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 17962)
		{
			date.text = "1796";

			title.text = "Escultura de Carlos IV";

			title.fontSize = 40;

			txt.text = "El 9 de diciembre, fecha del cumpleaños de la reina María Luisa, se inaugura la escultura provisional "
			+ "en madera del monarca Carlos IV,  mandada a hacer por el Virrey Miguel de la Grúa Salamanca y Branciforte, quien "
			+ "le encomienda este importante trabajo a Manuel Tolsá. Después de reunir los fondos para el vaciado de la escultura, "
			+ "en 1803, exactamente siete años más tarde, se devela el monumento ecuestre en bronce del monarca en la plaza principal "
			+ "en presencia del ahora Virrey José de Iturrigaray. Hoy en día se conoce esta escultura coloquialmente con el nombre "
			+ "del Caballito.";

			subPanel = true;

			siglo = "siglo XVIII/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + " (2)" + "/" + "A";
            subPanel2 = siglo + date.text + " (2)" + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1801)
		{
			date.text = "1801";

			title.text = "La elección del terreno";

			title.fontSize = 40;

			txt.text = "Al oriente de Guadalajara, muy cerca del río de San Juan de Dios, existía una vieja casa con huerta y solar, "
			+ "propiedad del Santuario de Nuestra Señora de la Soledad, que fue vendida el 19 de mayo al licenciado Pedro Díaz "
			+ "Escandón por mil ochocientos ochenta pesos. Posteriormente, Escandón cede esta propiedad para la construcción de lo que "
			+ "sería poco tiempo después la Casa de Caridad y Misericordia.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1804)
		{
			date.text = "1804-1805";

			title.text = "La Casa de la Misericordia";

			title.fontSize = 40;

			txt.text = "Con el terreno ya disponible, el obispo Cabañas solicita un proyecto arquitectónico a la Real Academia "
			+ "de San Carlos para la construcción de la Casa de la Caridad y Misericordia. El Director de la Academia, Don Antonio "
			+ "Jerónimo Gil y Manuel Tolsá, entonces director de arquitectura de la Academia, designan entre sus colaboradores al "
			+ "más capacitado para hacerse cargo de la construcción del inmueble. El arquitecto José Gutiérrez, académico de mérito "
			+ "de la Real Academia, tendrá a partir de ese momento la dirección total de la obra, y además se encargará de impartir "
			+ "clases de arquitectura en Guadalajara. La construcción de la Casa de la Misericordia se inicia en febrero de 1805 bajo "
			+ "la dirección de José Gutiérrez quien ya se encontraba en Guadalajara. Paralelamente el arquitecto construye el Puente "
			+ "Verde (ubicado en lo que hoy es la Calzada Independencia a la altura de Av. Revolución) para asegurar las vías de "
			+ "comunicación y de abastecimiento del centro de la ciudad a la casa de expósitos.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1810)
		{
            date.text = "1810";

			title.text = "Primeros asilados";

			title.fontSize = 40;

			txt.text = "El 1° de febrero, con la construcción casi finalizada (a excepción de la cúpula), la Casa de la Misericordia "
			+ "recibe a los primeros asilados –66 en total, entre niños y desvalidos–. Esta obra y el Hospital San Miguel de Belén "
			+ "serán las raíces de la filantropía en el Estado de Jalisco. \n" + "Este mismo año se suspenden las obras de construcción "
			+ "debido al movimiento insurgente, lo que provoca que la casa sea convertida en cuartel militar. El Obispo Cabañas huye "
			+ "hacia el puerto de Veracruz.";

			subPanel = false;
		}
		else if(number == 18102)
		{
			date.text =  "1810";

			title.text = "La guerra de Independencia";

			title.fontSize = 40;

			txt.text = "El 16 de septiembre, Miguel Hidalgo y Costilla hace el llamado a las armas en el pueblo de Dolores, Guanajuato. "
			+ "Inicia la guerra de Independencia.";

			subPanel = false;
		}
		else if(number == 18103)
		{
			date.text = "1810";

			title.text = "Miguel Hidalgo en Guadalajara";

			title.fontSize = 40;

			txt.text = "El 26 de noviembre, Miguel Hidalgo y Costilla hace su entrada triunfal en Guadalajara después de haber pasado "
			+ "por los municipios de Zamora, La Barca, Atequiza y Tlaquepaque.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (3)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (3)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + " (3)" + "/" + "A";
            subPanel2 = siglo + date.text + " (3)" + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 18104)
		{
			date.text =  "1810";

			title.text = "Manuel Gómez Ibarra";

			title.fontSize = 40;

			txt.text = "Nace en la hacienda La Labor Manuel Gómez Ibarra, destacado arquitecto, discípulo de José Gutiérrez, "
			+ "quien posteriormente se encargará de concluir la construcción de la cúpula de La Casa de la Misericordia.";

			subPanel = false;
		}
		else if(number == 1811)
		{
			date.text =  "1811";

			title.text = "Ciudadela Militar";

			title.fontSize = 40;

			txt.text = "El inmueble es fortificado utilizado como ciudadela por uno y otro bando durante la Guerra de Independencia, "
			+ "alojando a centenares de hombres y hasta 200 caballos.";

			subPanel = false;
		}
		else if(number == 1816)
		{
			date.text = "1816";

			title.text = "Muere Manuel Tolsá";

			title.fontSize = 40;

			txt.text = "El 24 de diciembre muere don Manuel Tolsá en la Ciudad de México, a causa de una úlcera gástrica.";

			subPanel = false;
		}
		else if(number == 1821)
		{
			date.text = "1821";

			title.text = "La Junta Patriótica de la Nueva Galicia";

			title.fontSize = 40;

			txt.text = "Tras el triunfo del Ejército Trigarante, el 22 de septiembre, se instala en Guadalajara la Junta Patriótica "
			+ "de la Nueva Galicia, destinada a promover la ilustración, las artes, la agricultura y la moral pública. En dicha junta "
			+ "el Obispo Cabañas pronuncia un discurso en el que eleva la educación de la juventud y las artes al progreso.";

			subPanel = false;
		}
		else if(number == 18212)
		{
            date.text = "1821";

			title.text = "Los Tratados de Córdoba";

			title.fontSize = 40;

			txt.text = "El 24 de agosto, Agustín de Iturbide y el Virrey Juan O' Donojú firman los Tratados de Córdoba, "
			+ "con los cuales se reconoce la independencia de México y se asume como forma de gobierno una monarquía institucional "
			+ "moderada.\n\nEl 27 de septiembre se consuma la independencia. El Ejército Trigarante al mando de Iturbide desfila "
			+ "victorioso por las calles de la Ciudad de México.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + " (2)" + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1823)
		{
			date.text = "1823";

			title.text = "Estado Libre y Soberano de Jalisco";

			title.fontSize = 40;

			txt.text = "El 16 de junio el imperialismo y el colonialismo quedan atrás, y surge el Estado Libre y Soberano de Xalisco.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1824)
		{
			date.text = "1824";

			title.text = "La primera Constitución";

			txt.text = "Se promulga la primera Constitución Federal de los Estados Unidos Mexicanos.";

			title.fontSize = 40;

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 18242)
		{
			date.text = "1824";

			title.text = "Muere el obispo Cabañas";

			title.fontSize = 40;

			txt.text = "El 23 de noviembre, muere el obispo Juan Cruz Ruiz de Cabañas y Crespo en la ciudad de Guadalajara. "
			+ "Como benefactor, no sólo inició el camino para construir la Casa de la Misericordia, hoy el Instituto Cultural Cabañas, "
			+ "si no que donó también recursos para el templo de San Felipe Neri, el Sagrario Metropolitano, el Santuario de Nuestra "
			+ "Señora de Zapopan y el Seminario Conciliar.";

			subPanel = false;
		}
		else if(number == 1825)
		{
			date.text = "1825";

			title.text = "Regreso de José Gutiérrez a Guadalajara";

			title.fontSize = 40;

			txt.text = "En enero, Prisciliano Sánchez Padilla toma posesión como primer gobernador del estado de Jalisco.\n\n"
			+ "José Gutiérrez en Guadalajara para reanudar los trabajos en el templo del Sagrario y realizar las modificaciones "
			+ "en la portada del antiguo templo de Santo Tomás.";

			subPanel = false;
		}
		else if(number == 1826)
		{
			date.text = "1826"; 

			title.text = "Prisciliano Sánchez";

			title.fontSize = 40;

			txt.text = "El 30 de diciembre muere Prisciliano Sánchez, el primer gobernador constitucional del estado de Jalisco.";

			subPanel = false;
		}
		else if(number == 1828)
		{
			date.text = "1828";

			title.text = "Se retoma la vocación de La Casa de la Misericordia";

			title.fontSize = 40;

			txt.text = "Como resultado de las gestiones del gobernador Juan N. Cumplido, los militares desocupan el inmueble, "
			+ "reiniciando las reparaciones y las obras inconclusas desde 1810.  En febrero abre nuevamente la Casa de la Caridad "
			+ "y Misericordia con 40 niños.";

			subPanel = false;
		}
		else if(number == 1833)
		{
			date.text = "1833";

			title.text = "Ciudadela militar";

			title.fontSize = 40;

			txt.text = "El Gobierno de Jalisco pretende convertir el edifico en una ciudadela y establecer talleres destinados a "
			+ "la fabricación de armas y equipos militares;  deseo que no se concreta al oponerse el cura Diego Aranda y Carmpinteiro "
			+ "al desalojo de los menores.   El hospicio inicia entonces un periodo de estabilidad y reconstrucción.";

			subPanel = false;
		}
		else if(number == 18332)
		{
			date.text = "1833";

			title.text = "Cólera en Guadalajara";

			title.fontSize = 40;

			txt.text = "El martes 3 de agosto, se propaga una epidemia de cólera morbus o cólera grande, como pasó a ser llamada por la "
			+ "tradición tapatía. Esta enfermedad fue tan mortífera que muchas de las actividades urbanas y familiares "
			+ "se desquiciaron; en el transcurso de ese día fallecieron 238 personas.";

			subPanel = false;
		}
		else if(number == 1834)
		{
			date.text = "1834";

			title.text = "Muere José Gutiérrez";

			txt.text = "Fallece el arquitecto José Gutiérrez en Guadalajara a la edad de sesenta y tres años, víctima de "
			+ "“irritación corporal”, que ahora correspondería a una fuerte infección.";

			title.fontSize = 40;

			subPanel = false;
		}
		else if(number == 1836)
		{
			date.text = "1836";

			title.text = "La construcción de la cúpula";

			title.fontSize = 40;

			txt.text = "Bajo el mandato del Obispo Diego de Aranda, Manuel Gómez Ibarra, discípulo del arquitecto José Gutiérrez, "
			+ "reinicia la construcción de la cúpula de la capilla de la Casa de la Misericordia, además introduce  agua potable al "
			+ "lugar.";

			subPanel = false;
		}
		else if(number == 1842)
		{
			date.text = "1842";

			title.text = "Antonio López de Santa Anna en  Guadalajara";

			title.fontSize = 40;

			txt.text = "Antonio López de Santa Anna entra a la ciudad.";

			subPanel = false;
		}
		else if(number == 1845)
		{
			date.text = "1845";

			title.text = "Culminación de la cúpula";

			title.fontSize = 40;

			txt.text = "Las bóvedas de la Casa de la Caridad y Misericordia son finalmente terminadas de acuerdo al proyecto inicial. "
			+ "Las obras estuvieron a cargo de Manuel Gómez Ibarra. A partir d entonces la Casa recibe el nombre de Hospicio Cabañas "
			+ "en honor a su fundador.";

			subPanel = false;
		}
		else if(number == 1852)
		{
			date.text = "1852";

			title.text = "Invasión Estadounidense";

			title.fontSize = 40;

			txt.text = "Se deterioran las relaciones de México con Estados Unidos y la Casa de la Misericordia vuelve a ser utilizada "
			+ "como  ciudadela;   los niños que la habitaban fueron enviados a distintos lugares de la ciudad.";

			subPanel = false;
		}
		else if(number == 1853)
		{
			date.text = "1853";

			title.text = "Las Hermanas de la Caridad";

			title.fontSize = 40;

			txt.text = "Se retoma la vocación de la Casa de la Misericordia y las Hermanas de la Caridad se encargan de atender la "
			+ "Institución a partir de este momento.";

			subPanel = false;
		}
		else if(number == 1857)
		{
			date.text = "1857";

			title.text = "La construcción del Teatro Degollado";

			title.fontSize = 40;

			txt.text = "La Real Universidad de Guadalajara se clausura. \n\n" 
			+ "El 5 de marzo, bajo el gobierno de José Santos Degollado, se coloca la primera piedra del Teatro Juan Ruiz de Alarcón, "
			+ "posteriormente conocido como el Teatro Degollado. La construcción estuvo a cargo del arquitecto Jacobo Gálvez.";

			subPanel = false;
		}
		else if(number == 1859)
		{
			date.text = "1859";

			title.text = "La Ley de Nacionalización de Bienes Eclesiásticos";

			title.fontSize = 40;

			txt.text = "El 12 de julio, en Veracruz, el presidente Benito Juárez expide la Ley de Nacionalización de los Bienes "
			+ "Eclesiásticos, por la cual, todas las propiedades de la iglesia pasan a ser dominio de la nación.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 18592)
		{
			date.text = "1859";

			title.text = "La constitución política de la República Mexicana";

			txt.text = "Se promulga la Constitución Política de la República Mexicana de ideología liberal durante la presidencia "
			+ "de Ignacio Comonfort.";

			title.fontSize = 40;

			subPanel = false;
		}
		else if(number == 1860)
		{
			date.text = "1860";

			title.text = "Sor Ignacia Osés";

			title.fontSize = 40;

			txt.text = "El Hospicio Cabañas recibe como directora a Sor Ignacia Osés, quién desempeñará este cargo hasta 1874. "
			+ "Gracias a su impecable administración y generosidad, este periodo será conocido como la época de oro del Hospicio. "
			+ "Durante este tiempo, con el apoyo del gran benefactor Juan José Matute, se crean el asilo de mendigos, el departamento "
			+ "de cuna y talleres; se brinda ropa a los internos; y se decide bajo el gobierno eclesiástico que todos los niños "
			+ "expósitos llevarán el apellido Cabañas en memoria de su fundador.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1862)
		{
            date.text = "1862-1867";

			title.text = "La Intervención Francesa";

			txt.text = "Debido a que el presidente Benito Juárez suspendió los pagos de la deuda externa del país en 1861, Francia, "
			+ "Inglaterra y España envían tropas a México. Con el Tratado de la Soledad, las tropas inglesas y españolas se retiran. "
			+ "El ejército francés continúa a Puebla donde es derrotado en una batalla el 5 de mayo. Posteriormente, los franceses "
			+ "reciben refuerzos y continúan hasta ocupar la ciudad de México y Guadalajara.";

			title.fontSize = 40;
		
			subPanel = false;
		}
		else if(number == 1864)
		{
			date.text = "1864";

			title.text = "Crisis en el Hospicio Cabañas";

			title.fontSize = 40;

			txt.text = "Como consecuencia de la Ley de Nacionalización de Bienes Eclesiásticos, la Institución pasa por un periodo "
			+ "difícil debido a los recortes de gastos y el déficit. Fernando Díaz de Escandón, administrador del Hospicio Cabañas, "
			+ "vende la huerta que se extiende al frente del edificio hasta el río San Juan de Dios para así poder sobrellevar la "
			+ "grave situación económica.";

			subPanel = false;
		}
		else if(number == 18642)
		{
			date.text = "1864";

			title.text = "El emperador Maximiliano de Habsburgo";

			title.fontSize = 40;

			txt.text = "El archiduque Fernando Maximiliano de Habsburgo recibe el título de emperador de México, ofrecido por una "
			+ "comisión donde se encontraba Juan Nepomuceno Almonte, hijo de José María Morelos y Pavón, con el beneplácito de "
			+ "Napoleón III de Francia.";

			subPanel = false;
		}
        else if(number == 1865)
        {
            date.text = "1865";

            title.text = "Informe sobre el Hospicio Cabañas";

            title.fontSize = 40;

            txt.text = "Los miembros del Consejo Superior de Beneficencia elaboran un informe donde se asienta que las 17 monjas que "
            + "había en el Hospicio Cabañas, se encargaban de siete departamentos: hombres y mujeres adultos pobres, niños y niñas "
            + "pobres, casa de cuna, visita domiciliaria y el colegio de pensionistas y asiladas. Todos los internos recibían "
            + "instrucción primaria y posteriormente aprendían algún oficio, como el bordado, la cocina, la zapatería, la carpintería o "
            + "la imprenta.   Cabe mencionar que el primer libro editado en Guadalajara se imprimió en este recinto.";

            subPanel = false;
        }
        else if(number == 1871)
		{
			date.text = "1871";

			title.text = "El gobernador Ignacio Luis Vallarta Ogazón";

			title.fontSize = 40;

			txt.text = "Inicia el gobierno de Ignacio Luis Vallarta en Jalisco. Su gubernatura concluye en 1875. Durante su gobierno, "
			+ "se fundó la Escuela de Agricultura y se estableció la obligatoriedad de la educación primaria.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1874)
		{
			date.text = "1874";

			title.text = "La expulsión de las Hermanas de la Caridad";

			title.fontSize = 40;

			txt.text = "A causa de las Leyes de Reforma, el 14 de diciembre son expulsadas del país las Hermanas de la Caridad. "
			+ "La administración del hospicio recae en las autoridades estatales.";

			subPanel = false;
		}
		else if(number == 1876)
		{
			date.text = "1876";

			title.text = "Primer mandato de Porfirio Díaz";

			title.fontSize = 40;

			txt.text = "Después de la Revolución de Tuxtepec, el 24 de noviembre, Porfirio Díaz Mori inicia su primer mandato que "
			+ "finaliza el 6 de diciembre del mismo año.";

			subPanel = true;

			siglo = "siglo XIX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
        else if(number == 1879)
		{
			date.text = "1879";

			title.text = "Epidemia de tifoidea";

			title.fontSize = 40;

			txt.text = "Esta pandemia obliga a evacuar a 389 asilados, quedando 214 enfermos en el hospicio, gracias a los esfuerzos "
			+ "de su directora Luisa del Castillo y Pacheco sólo mueren 14, ella se encuentra entre las víctimas.";

			subPanel = false;

			siglo = "siglo XIX/";
		}
		else if(number == 1883)
		{
			date.text = "1883";

			title.text = "Bases reglamentarias del Hospicio";

			title.fontSize = 40;

			txt.text = "Siendo gobernador el General Francisco Tolentino y directora la Sra. Luz Herrera, se acordaron las nuevas bases "
			+ "reglamentarias del Hospicio que substituyeron a las ordenanzas de la Casa de Caridad y Misericordia, la institución fue "
			+ "nombrada oficialmente “Hospicio de Guadalajara” que integra una casa de expósitos, asilo de huérfanos, escuela de artes, "
			+ "tejido y contabilidad.";

			subPanel = false;

			siglo = "siglo XIX/";
		}
		else if(number == 18832)
		{
			date.text = "1883";

			title.text = "Nace José Clemente Orozco";

			title.fontSize = 40;

			txt.text = "El 23 de noviembre, el muralista José Clemente Ángel Orozco Flores nace en Zapotlán el Grande, Jalisco.";

			subPanel = false;
		}
		else if(number == 1889)
		{
			date.text = "1889";

			title.text = "El primer ferrocarril";

			title.fontSize = 40;

			txt.text = "El primer ferrocarril llega a Guadalajara desde la Ciudad de México. \n\n"
			+ "Muere asesinado el general Ramón Corona, gobernador del Estado de Jalisco.";

			subPanel = false;
		}
		else if(number == 1893)
		{
			date.text = "1893";

			title.text = "Porfirio Díaz es presidente por cuarta ocasión";

			txt.text = "El general Porfirio Díaz Mori rinde protesta como Presidente Constitucional.";

			title.fontSize = 40;

			subPanel = false;
		}
		else if(number == 1899)
		{
			date.text = "1899";

			title.text = "Epidemias de tifo en México";

			title.fontSize = 40;

			txt.text = "Se propagan epidemias de tifo y viruela en el país que ocasionan más de 50,000 muertos.";

			subPanel = false;
		}
		else if(number == 1902)
		{
			date.text = "1902";

			title.text = "Fundación del periódico Regeneración";

			title.fontSize = 40;

			txt.text = "Los hermanos Ricardo y Jesús Flores Magón fundan y editan el periódico “Regeneración“ y “El hijo del Ahuizote“, "
			+ "a través de estos medios atacan la dictadura de Porfirio Díaz.  Ambos periódicos fueron suprimidos por el régimen "
			+ "dictatorial.";

			subPanel = false;
		}
		else if(number == 1909)
		{
			date.text = "1909";

			title.text = "Población en el Hospicio Cabañas";

			title.fontSize = 40;

			txt.text = "El Hospicio alberga 772 personas entre asilados y empleados.";

			subPanel = false;
		}
		else if(number == 1910)
		{
			date.text = "1910";

			title.text = "La Revolución mexicana";

			title.fontSize = 40;

			txt.text = "El 20 de noviembre, estalla la Revolución Mexicana liderada por Francisco Ignacio Madero. \n\n"
			+ "Para entonces, el Hospicio albergaba un total de 770 personas, entre asilados y empleados. Durante este "
			+ "periodo revolucionario, el lugar no experimentó muchos cambios en cuanto a su fisionomía, salvo algunas "
			+ "rehabilitaciones en los muros.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1913)
		{
			date.text = "1913";

			title.text = "La Decena Trágica";

			title.fontSize = 40;

			txt.text = "Del 9 al 19 de febrero inicia un golpe militar en la ciudad de México conocido como la Decena Trágica, "
			+ "con el propósito de derrocar el gobierno de Francisco I. Madero.";

			subPanel = false;
		}
		else if(number == 1914)
		{
			date.text = "1914";

			title.text = "La ocupación de los estadounidenses";

			title.fontSize = 40;

			txt.text = "En oposición al gobierno de Victoriano Huerta y con pobres relaciones diplomáticas con México, "
			+ "Estados Unidos toma el puerto de Veracruz el 21 de abril de 1914.";

			subPanel = false;
		}
		else if(number == 1917)
		{
			date.text = "1917";

			title.text = "Promulgación de la Constitución ";

			title.fontSize = 40;

			txt.text = "El 5 de febrero el presidente Venustiano Carranza proclama la Constitución Política de los Estados "
			+ "Unidos Mexicanos, que reforma la del 5 de febrero de 1857, especialmente lo referente a los derechos humanos "
			+ "aunque ya no los menciona como tales, sino que alude a las llamadas garantías individuales.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
        else if(number == 1922)
		{
			date.text = "1922";

			title.text = "Capilla Mayor";

			title.fontSize = 40;

			txt.text = "Se retira de la Capilla Mayor el altar de estilo gótico, que había sido construido en 1807.";

			subPanel = false;
        }
		else if(number == 1926)
		{
			date.text = "1926";

			title.text = "La Universidad de Guadalajara";

			title.fontSize = 40;

			txt.text = "El 12 de octubre el gobernador de Jalisco, José Guadalupe Zuno Hernández, reabre La Real Universidad de "
			+ "Guadalajara bajo el nombre de “Universidad de Guadalajara”, como institución pública, laica, gratuita y abierta a "
			+ "todos los ciudadanos. Este acto permitió concretar los ideales posrevolucionarios de la educación. En esta nueva etapa "
			+ "la universidad es impulsada por el primer rector Enrique Díaz de León y un grupo de intelectuales de las ciencias y las "
			+ "artes denominado Centro Bohemio, grupo que reunía a notables artistas plásticos de la época en Jalisco, entre algunos: "
			+ "Xavier Guerrero (1896-1974), Carlos Orozco Romero (1898-1984) y David Alfaro Siqueiros (1896-1974).";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 19262)
		{
			date.text = "1926";

			title.text = "La Guerra Cristera";

			title.fontSize = 40;

			txt.text = "La guerra Cristera o Cristiada, un conflicto posrevolucionario entre 1926 y 1929 durante el mandato de "
			+ "Plutarco Elías Calles, fue de gran impacto en el occidente de México. Las inconformidades de las autoridades "
			+ "eclesiásticas respecto de las Leyes de Reforma, con las que se buscaba que la Iglesia Católica se viera aminorada "
			+ "en su capacidad económica y política, fueron las causas principales del levantamiento armado. \n\n" 
			+ "El 21 de junio de 1929 el gobierno de Emilio Portes Gil, quien toma el mando del país después del atentado contra "
			+ "Álvaro Obregón, reanuda el diálogo y establece acuerdos que dan por terminado el movimiento Cristero.";

			subPanel = false;
		}
		else if(number == 1937)
		{
			date.text = "1937";

			title.text = "Clausura de la Universidad";

			title.fontSize = 40;

			txt.text = "Tras una serie de conflictos estudiantiles ocasionados por el impulso de aplicar la educación socialista en "
			+ "la Universidad de Guadalajara que el rector Enrique Díaz de León da a conocer durante el Primer Congreso de "
			+ "Universitarios en la ciudad de México, el gobernador Sebastián Allende decide clausurar la universidad.";

			subPanel = false;
		}
		else if(number == 19372)
		{
            date.text = "1937";

			title.text = "Orozco en Guadalajara";

			title.fontSize = 40;

			txt.text = "A instancias del gobernador de Jalisco, Everardo Topete, el artista José Clemente Orozco es llamado a pintar "
			+ "edificios públicos de la ciudad, entre ellos la que sería sede del Palacio Legislativo (hoy Museo de las Artes de la "
			+ "Universidad de Guadalajara), el Palacio de Gobierno y el interior de la capilla del Hospicio Cabañas. \n\n"
			+ "Este artista realizó 57 murales al fresco en el conjunto arquitectónico de la Capilla Mayor del Hospicio Cabañas. "
			+ "A decir de los especialistas, la obra cumbre de José Clemente Orozco. ";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + " (2)" + "/" + "A";
            subPanel2 = siglo + date.text + " (2)" + "/" + "B";
            subPanel3 = siglo + date.text + " (2)" + "/" + "C";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 19373)
		{
			date.text = "1937";

			title.text = "La reapertura de la Universidad de Guadalajara";

			title.fontSize = 40;

			txt.text = "El 22 de julio, bajo la rectoría de Constancio Hernández Alvirde, se restaura la universidad para evitar "
			+ "que la Universidad Autónoma de Guadalajara se apodere de la histórica denominación, Universidad de Guadalajara.";

			subPanel = false;
		}
		else if(number == 1948)
		{
			date.text = "1948";

			title.text = "La Cruz de Plazas";

			title.fontSize = 40;

			txt.text = "Por órdenes del gobernador de Jalisco, José de Jesús González Gallo, el arquitecto Ignacio Díaz Morales "
			+ "recibe la comisión de aumentar el número de espacios públicos de la ciudad de Guadalajara. Así nace el proyecto de "
			+ "La Cruz de Plazas comprendidas por: la Plaza de Armas fundada en 1561, la Rotonda de los Jaliscienses Ilustres "
			+ "(antes Jardín Herrera y Cairo y Templo de la Soledad), la Plaza Liberación (comprendida por dos manzanas entre el "
			+ "Teatro Degollado y la catedral) y las fincas ubicadas frente a la catedral.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1949)
		{
			date.text = "1949";

			title.text = "La facultad de Arquitectura";

			title.fontSize = 40;

			txt.text = "Bajo el liderazgo del arquitecto Ignacio Díaz Morales, se funda  la facultad de Arquitectura de la Universidad de Guadalajara.";

			subPanel = false;
		}
		else if(number == 19492)
		{
			date.text = "1949";

			title.text = "Muere José Clemente Orozco";

			title.fontSize = 40;

			txt.text = "El 7 de septiembre, José Clemente Orozco muere en la ciudad de México a los sesenta y seis años de edad.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Design/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Design/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + " (2)" + "/" + "A";
            subPanel2 = siglo + date.text + " (2)" + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1953)
		{
			date.text = "1953-1954";

			title.text = "Restauración de la cúpula";

			title.fontSize = 40;

			txt.text = "Durante la gubernatura de Agustín Yañez Delgadillo se restaura la cúpula de la capilla mayor; actividad "
			+ "realizada por el ingeniero Jorge Matute Remus en colaboración con el ingeniero Edmundo Ponce Adame y el arquitecto "
			+ "Silvio Alberti.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
		}
		else if(number == 1956)
		{
			date.text = "1956";

			title.text = "La Rotonda de los Jaliscienses Ilustres";

			title.fontSize = 40;

			txt.text = "Con un proyecto del arquitecto Vicente Mendiola, el ingeniero Miguel Aldana termina la construcción de la "
			+ "Rotonda de los Jaliscienses Ilustres, donde antes estuvieron ubicados el Santuario de la Soledad y el Seminario del "
			+ "Señor San José.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
		else if(number == 1960)
		{

			date.text = "1960";

			title.text = "Estructura legal del Hospicio Cabañas";

			title.fontSize = 40;

			txt.text = "Siendo Gobernador del Estado de Jalisco el Prof. Juan Gil Preciado, se redefinió la estructura legal "
			+ "del Hospicio Cabañas";

			subPanel = false;
		}
		else if(number == 1962)
		{
			date.text = "1962";

			title.text = "El mercado San Juan de Dios ";

			title.fontSize = 40;

			txt.text = "Siendo gobernador del Estado de Jalisco el Prof. Juan Gil Preciado, después de cuatro años de construcción "
			+ "se concluye, a un costado del Hospicio Cabañas, el Mercado Libertad, mejor conocido como San Juan de Dios, proyecto del "
			+ "arquitecto Alejandro Zohn. Estos dos edificios se convierten en símbolos emblemáticos de la zona y son fundamentales del "
			+ "paisaje urbano de Guadalajara.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
		}
		else if(number == 1963)
		{
			date.text = "1963";

			title.text = "El Condominio Guadalajara";

			title.fontSize = 40;

			txt.text = "Julio de la Peña construye el Condominio Guadalajara, símbolo de una ciudad moderna. El edificio es parte "
			+ "de un proyecto urbanístico que pretendía expandir la dinámica urbana del centro histórico y descentralizarla.";

			subPanel = false;
		}
		else if(number == 1964)
		{
			date.text = "1964";

			title.text = "El Museo Nacional de Antropología";

			title.fontSize = 40;

			txt.text = "Se inaugura el Museo Nacional de Antropología, diseñado por el arquitecto Pedro Ramírez Vázquez. "
			+ "Este museo se volvió el modelo a seguir en cuanto a museología y funcionalidad. Ha sido desde entonces un recinto "
			+ "museístico referencial para todo el país.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 1968)
		{
			date.text = "1968";

        	title.text = "Juegos Olímpicos. México 68";

        	title.fontSize = 40;

        	txt.text = "En un contexto deportivo y cultural, se realizan los Juegos Olímpicos de la XIX Olimpiada en México "
			+ "retomando por primera vez la Olimpiada Cultural que iniciara el barón Pierre de Coubertin. "
			+ "Esta Olimpiada posiciona al país a nivel mundial.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 19682)
		{
			date.text = "1968";

			title.text = "Ruta de la Amistad";

			title.fontSize = 40;

			txt.text = "En el contexto de la XIX Olimpiada en México, se lleva a cabo la “Olimpiada Cultural”, uno de los programas "
			+ "incluye la invitación a los países participantes al corredor escultórico llamado “Ruta de la Amistad”, y se conforma un "
			+ "gran legado con los mejores artistas del mundo.";

			subPanel = false;
		}
		else if(number == 1976)
		{
			date.text = "1976";

			title.text = "El fin de la dictadura franquista";

			title.fontSize = 40;

			txt.text = "Muere Francisco Franco, termina la dictadura española e inicia el “Destape” y la “Movida Madrileña”, "
			+ "movimientos de contracultura postfranquista.";

			subPanel = false;
		}
		else if(number == 1979)
		{
			date.text = "1979";

			title.text = "Plaza Tapatía";

			title.fontSize = 40;

			txt.text = "Con la llegada de Flavio Romero de Velasco a la gubernatura del Estado de Jalisco, se inicia el proyecto que "
			+ "unirá al teatro Degollado con el Hospicio Cabañas:  la Plaza Tapatía la cual fue inaugurada el 5 de febrero de 1982 con "
			+ "la develación de diversas esculturas realizadas por Rafael Zamarripa – La Fundación y el Escudo de Guadalajara-  Víctor "
			+ "Contreras –Inmolación a Quetzalcóatl y Jorge de la Peña –La estampida-.";

			subPanel = true;

			siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
		}
        else if (number == 1980)
        {
            date.text = "1980";

            title.text = "Cambio de vocación del Hospicio";

            title.fontSize = 40;

            txt.text = "Bajo el gobierno de Flavio Romero de Velasco en el Estado de Jalisco y la creación de la Plaza Tapatía, "
            + "surge la idea de convertir el inmueble en un espacio dedicado a la difusión y promoción de la cultura y trasladar "
            + "a los niños a un recinto con áreas verdes y adecuadas a sus necesidades. Así nace el Instituto Cultural Cabañas";

            subPanel = true;

            siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = siglo + date.text + "/" + "D";
        }
        else if(number == 19802)
        {
            date.text = "1980";

            title.text = "Hogar Cabañas";

            title.fontSize = 40;

            txt.text = "El 13 de mayo de 1980 los niños son reubicados a las nuevas instalaciones del Hogar Cabañas con áreas verdes, "
            + "alberca y espacios funcionales para una mejor estancia.";

            subPanel = true;

            siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + " (2)" + "/" + "A";
            subPanel2 = siglo + date.text + " (2)" + "/" + "B";
            subPanel3 = siglo + date.text + " (2)" + "/" + "C";
            subPanel4 = siglo + date.text + " (2)" + "/" + "D";
        }
		else if(number == 19803)
		{
			date.text = "1980";

			title.text = "Decreto de Creación";

			title.fontSize = 40;

			txt.text = "Se publica el decreto de creación del Instituto Cultural Cabañas.";

			subPanel = false;
		}
		else if(number == 1983)
		{
			date.text = "1983";

			title.text = "Instituto Cultural Cabañas";

			title.fontSize = 40;

			txt.text = "El Gobierno del Estado de Jalisco toma el inmueble e inicia su remozamiento con fines culturales. "
			+ "Nace el Instituto Cultural Cabañas con el propósito principal de resguardar, conservar y divulgar la obra de "
			+ "José Clemente Orozco.";

			subPanel = true;

            siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = "DefaultImagen";
        }
        else if(number == 1984)
		{
			date.text = "1984";

			title.text = "INBA / ICC";

			title.fontSize = 40;

			txt.text = "El Instituto Nacional de Bellas Artes, INBA, le encomienda en resguardo al Instituto Cultural Cabañas, "
			+ "330 obras en soporte de papel y 10 piroxilinas de este artista Jalisciense.";

			subPanel = false;
		}
		else if(number == 1991)
		{
			date.text = "1991";

			title.text = "La primer Cumbre Iberoamericana";

			title.fontSize = 40;

			txt.text = "Los días 18 y 19 de julio se reunieron por primera vez los jefes de Estado de 21 países Iberoamericanos, "
			+ "teniendo como sede el recinto Hospicio Cabañas. Los mandatarios asentaron aquí las bases para la construcción de un "
			+ "foro de encuentro que les permitiera avanzar en un proceso común tanto político como económico y cultural.";

			subPanel = false;
        }
        else if(number == 1992)
		{
			date.text = "1992";

			title.text = "La sala de los magos";

			title.fontSize = 40;

			txt.text = "En la explanada del Instituto Cultural Cabañas, se instala La sala de los magos del artista Alejandro Colunga. "
			+ "Para el artista es importante la interacción de la obra con el público, razón por la cual eligió utilizar elementos "
			+ "funcionales como las sillas.";

			subPanel = false;
        }
		else if(number == 1993)
		{
			date.text = "1993-1994";

			title.text = "Colección Pueblo de Jalisco";

			title.fontSize = 40;

			txt.text = "Siendo gobernador de Jalisco el profesor Juan Gil Preciado, la promotora de arte Carmen Marín de Barreda, "
			+ "le propuso formar una colección de pinturas y de esculturas realizadas por artistas plásticos oriundos de Jalisco, "
			+ "formando un importante acervo que desde entonces se denominó Colección Pueblo de Jalisco, este acervo se integra con "
			+ "obras de Gerardo Murillo “Dr. Atl”, de Roberto Montenegro, Jesús Guerrero Galván, Raúl Anguiano,  Jorge González "
			+ "Camarena, Jorge Enciso, Juan Soriano, Ignacio Aguirre, Alfredo España, Javier Arévalo, Gabriel Flores, Guillermo "
			+ "Chávez Vega, José Luis Figueroa, Carlos Orozco Romero, Jesús “Chucho” Reyes Ferreira, entre otros, y las esculturas de "
			+ "Fidencio Castillo, Rosa Castillo y Francisco Marín. \n\nEn el año de 1982, el gobernador del estado de Jalisco, "
			+ "Flavio Romero de Velasco determinó que la Colección Pueblo de Jalisco fuese parte de los acervos del recién creado "
			+ "Instituto Cultural Cabañas. \n\nLa doctora Ana Cecilia Treviño entrega en donación al Instituto Cultural Cabañas "
			+ "239 obras que conforman la colección Mathias Goeritz.";

			subPanel = true;

            siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
        else if(number == 1994)
		{
			date.text = "1994";

			title.text = "La colección Mathias Goeritz";

			title.fontSize = 40;

			txt.text = "La doctora Ana Cecilia Treviño entrega en donación al Instituto Cultural Cabañas  239 obras que conforman "
			+ "la colección Mathias Goeritz.";

			subPanel = false;
        }
        else if(number == 1996)
		{
			date.text = "1996";

			title.text = "Cambios en la Capilla Tolsá";

			title.fontSize = 40;

			txt.text = "Bajo la dirección del arquitecto Ignacio Gómez Arreola, se hacen aplanados exteriores en la Capilla Tolsá, "
			+ "se restituye el enjarre en la antigua cocina y se habilita como sala de usos múltiples.";

			subPanel = false;
        }
		else if(number == 1997)
		{
			date.text = "1997";

			title.text = "El Hospicio Cabañas, Patrimonio de la Humanidad";

			title.fontSize = 35;

			txt.text = "El Comité del Patrimonio Mundial de Organización de las Naciones Unidas para la Educación, la Ciencia y la "
			+ "Cultura, UNESCO, en su vigésima primera reunión, celebrada en Nápoles, Italia, del 1 al 6 de diciembre, determina que "
			+ "por su belleza arquitectónica e importancia histórica y cultural, el Instituto Cultural Cabañas sea nombrado Patrimonio "
			+ "Cultural de la Humanidad.";

			subPanel = true;

            siglo = "siglo XX/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
		}
		else if(number == 2003)
		{
			date.text = "2003";

			title.text = "La rehabilitación del Cabañas";

			title.fontSize = 40;

			txt.text = "Siendo gobernador del Estado de Jalisco Francisco Ramírez Acuña, se comienzan los trabajos de rehabilitación "
			+ "para dotar al inmueble de la infraestructura necesaria para convertirse en museo. \n\n" 
			+ "El Centro Nacional de Conservación y Registro del Patrimonio Artístico Mueble, CENCROPAM, "
			+ "inicia los trabajos de conservación del mural El hombre de fuego de José Clemente Orozco.";

            subPanel = false;
		}
        else if (number == 2004)
        {
            date.text = "2004";

            title.text = "III Cumbre de América Latina, El Caribe y la Unión Europea";

            title.fontSize = 35;

            txt.text = "Los días 28 y 29 de mayo se celebró la III Cumbre de América Latina, El Caribe y la Unión Europea, misma que "
            + "tuvo su sede en el Instituto Cultural Cabañas.  En esta ocasión los Jefes  de 58 estados, se reunieron para dar "
            + "seguimiento a la “Asociación estratégica birregional”,  la cual tenía como uno de los principales temas a tratar la "
            + "guerra de Irak, reabrir el debate sobre la estrategia estadounidense frente al terrorismo global, así como reforzar el "
            + "papel de la ONU y regresar a la vía del multilateralismo para enfrentar la compleja situación mundial. \n\n"
            + "Este mismo año se integra como directora del ICC, la Lic. Elena Matute Villaseñor, cargo que realiza hasta el 2006. "
            + "Durante el periodo de la Cumbre y de las restauraciones, el inmueble permanece cerrado al público.";

            subPanel = false;
        }
        else if (number == 2005)
        {
            date.text = "2005";

            title.text = "Colección Roberto Montenegro";

            title.fontSize = 40;

            txt.text = "El Instituto Nacional de Bellas Artes, INBA, entrega en resguardo del Instituto Cultural Cabañas 1 015 obras "
            + "de la colección Roberto Montenegro.";

            subPanel = false;
        }
        else if (number == 2006)
        {
            date.text = "2005";

            title.text = "Colección de Arte Popular";

            title.fontSize = 40;

            txt.text = "Se encomienda al Instituto Cultural Cabañas el reguardo de una valiosa colección de arte popular que se exhibía "
            + "en la Casa de las Artesanías del Agua Azul. Esta colección incluye piezas de cerámica de Tonalá, de Tlaquepaque y loza "
            + "antigua de Sayula; realizada en vidrio soplado, madera y metal, textiles y mil objetos más de gran calidad artesanal.";

            subPanel = false;
        }
        else if(number == 2007)
		{
			date.text = "2007";

			title.fontSize = 35;

			title.text = "X aniversario como Patrimonio de la Humanidad";

			txt.text = "En este año se conmemora el décimo aniversario del Instituto Cultural Cabañas como Patrimonio de la Humanidad. \n\n"
			+ "El Consejo Nacional para la Cultura y las Artes, CONACULTA, otorga al Instituto Cultural Cabañas un recurso "
			+ "extraordinario para el acondicionamiento de las salas museográficas con la intención de que cubran los estándares "
			+ "internacionales que marca el Consejo Internacional de Museos, ICOM.";

			subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = "DefaultImagen";
		}
		else if (number == 2009)
        {
            date.text = "2009";

            title.text = "III Cumbre de Líderes de América del Norte";

            title.fontSize = 40;

            txt.text = "Se realizó los días 9 y 10 de agosto con la participación de los Presidentes Felipe Calderón de México, "
            + "Barack Obama de Estados Unidos y el Primer Ministro de Canadá, Stephen Harper.";

            subPanel = false;
        }
        else if (number == 2010)
        {
            date.text = "2010";

            title.text = "Restauración de murales";

            title.fontSize = 40;

            txt.text = "El Instituto Nacional de Bellas Artes y la Secretaría de Cultura restauran el mural El hombre de fuego "
            + "y las pechinas de la cúpula de la Capilla Mayor.";

            subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
        else if(number == 2014)
		{
            date.text = "2014-2015";

			title.text = "Restauración del inmueble";

			title.fontSize = 40;

			txt.text = "Siendo gobernador del Estado de Jalisco, el maestro Jorge Aristóteles Sandoval Díaz, "
			+ "y con el apoyo del entonces Consejo Nacional para la Cultura Federal y las Artes (CONACULTA) hoy Secretaría de Cultura, "
			+ "se llevan a cabo obras de restauración al edificio Hospicio Cabañas que alberga al Instituto Cultural Cabañas.";

			subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = "DefaultImagen";
            subPanel3 = "DefaultImagen";
            subPanel4 = "DefaultImagen";
        }
        else if (number == 2015)
        {
            date.text = "2015";

            title.text = "Conservación y restauración de los murales.";

            title.fontSize = 35;

            txt.text = "Con la finalidad de continuar con la preservación del Patrimonio Cultural e Histórico de nuestra ciudad, "
            + "se inicia el proyecto para la restauración de la Capilla Mayor y de las colecciones que alberga el "
            + "Instituto Cultural Cabañas con el apoyo de la Comisión de Cultura del Congreso del Estado "
            + "y la secretaría de Cultura del Estado. \n\n Se restauran los murales con el tema de La Conquista de José Clemente Orozco"
            + " que se encuentran en la Capilla Mayor del instituto.";

            subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = "DefaultImagen";
        }
        else if (number == 20152)
        {
			date.text = "2015";

			title.text = "Restauración Mathias Goeritz";

			title.fontSize = 40;

			txt.text = "Con motivo del 100 aniversario del nacimiento del artista alemán Mathias Goeritz, "
            + "se lleva a cabo la restauración de 82 obras en soporte de papel y una obra escultórica conformada por 27 piezas.";

			subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (2)" + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + " (2)" + "/" + "A";
            subPanel2 = siglo + date.text + " (2)" + "/" + "B";
            subPanel3 = siglo + date.text + " (2)" + "/" + "C";
            subPanel4 = siglo + date.text + " (2)" + "/" + "D";
        }
        else if(number == 20153)
		{
            date.text = "2015";

            title.text = "Adquisición de obra";

            title.fontSize = 40;

            txt.text = "Con el objetivo de que en la Colección Pueblo de Jalisco estén representados, tanto los grandes artistas "
			+ "como los jóvenes profesionales de la plástica jaliscienses, la Secretaría de Cultura del Gobierno del "
			+ "Estado de Jalisco asigna una partida para la adquisición de 15 obras que incrementan y actualizan la colección que "
			+ "desde 1964 había permanecido estática.";

            subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (3)" + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (3)" + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (3)" + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + " (3)" + "/" + "D") as Sprite;

            subPanel1 = siglo + date.text + " (3)" + "/" + "A";
            subPanel2 = siglo + date.text + " (3)" + "/" + "B";
            subPanel3 = siglo + date.text + " (3)" + "/" + "C";
            subPanel4 = siglo + date.text + " (3)" + "/" + "D";
		}
		else if(number == 2016)
		{
            date.text = "2016";

            title.text = "Proyecto Línea del Tiempo";

            title.fontSize = 40;

            txt.text = "Se inicia un convenio de colaboración entre la Universidad de Guadalajara a través  del Sistema de "
            + "Universidad Virtual y de la Maestria en Gestión y Desarrollo Cultural para llevar a cabo la Línea del Tiempo Virtual "
            + "del Museo de Sitio de este Instituto. ";

            subPanel = false;
		}
		else if(number == 2017)
		{
			date.text = "2017";

			title.text = "El Cabañas hoy";

			txt.text = "Actualmente el Instituto Cultural Cabañas tiene bajo su resguardo las colecciones: José Clemente Orozo y "
			+ "Roberto Montenegro, acervos del INBA, Pueblo de Jalisco, Mathias Goeritz, Carlos Sthal, Artes Populares, "
			+ "Consejo Estatal para la Cultura y las Artes (CECA) y Pago en Especie. "
			+ "Dos fondos documentales: Hospicio Cabañas y Mathias Goeritz; tres fondos fotográficos: Mathias Goeritz, "
			+ "José María Lupercio y  Mariana Yampolsky. \n\n" 
			+ "Cuenta con 29 salas museográficas para exhibiciones permanentes y temporales que a lo largo de cada año alberga "
			+ "propuestas de artistas locales, nacionales e internacionales. Seis salas cuyo objetivo es presentar de forma "
			+ "permanente las obras que conforman las colecciones en custodia del Instituto Cultural Cabañas. \n\n" 
			+ "Para la producción de las exposiciones, el Instituto ha creado alianzas con importantes instituciones culturales "
			+ "y artísticas de México y el extranjero tanto del ámbito público como privado. \n\n" 
			+ "Hoy por hoy el Instituto Cultural Cabañas alberga uno de los museos más importantes del "
			+ "país y se ha convertido en un referente cultural y artístico en el mundo.";

			title.fontSize = 40;

			subPanel = true;

            siglo = "siglo XXI/";

            panel1.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "A") as Sprite;
            panel2.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "B") as Sprite;
            panel3.sprite = Resources.Load<Sprite>("Images/" + siglo + date.text + "/" + "C") as Sprite;
            panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;

            subPanel1 = siglo + date.text + "/" + "A";
            subPanel2 = siglo + date.text + "/" + "B";
            subPanel3 = siglo + date.text + "/" + "C";
            subPanel4 = "DefaultImagen";
		}
		if (subPanel == false)
		{
			subPanel1 = "DefaultImagen";
			subPanel2 = "DefaultImagen";
			subPanel3 = "DefaultImagen";
			subPanel4 = "DefaultImagen";

			panel1.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
			panel2.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
			panel3.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
			panel4.sprite = Resources.Load<Sprite>("Images/DefaultImagen") as Sprite;
		}
	}
}