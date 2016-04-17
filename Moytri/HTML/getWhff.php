
<?php

	//$latt=35;$lonn=139;
	$latt=$_POST['lat'];$lonn=$_POST['lon'];
    $request = "http://api.openweathermap.org/data/2.5/weather?lat=".$latt."&lon=".$lonn."&appid=b1b15e88fa797225412429c1c50c122a";
    $response  = file_get_contents($request);
    $json_obj  = json_decode($response);
	$data=$json_obj;
	//$weather = $data -> weather;
	$mainObject = $data -> main; // retrieve main Object
		$temp = $mainObject -> temp; // retrieve temp from main Object
		$pressure = $mainObject -> pressure; // retrieve temp from main Object
		$humidity = $mainObject -> humidity; // retrieve temp from main Object
		$temp_min = $mainObject -> temp_min; // retrieve temp from main Object
		$temp_max = $mainObject -> temp_max; // retrieve temp from main Object


	$windObject=$data->wind;
		$speed=$windObject->speed;
		$degree=$windObject->deg;

 function k2c($l){
	 return $l-273;
 }
 
 
 echo "
<h2>Tempareture : ".k2c($temp)." C </h2>
<h2>Pressure : $pressure atm</h2>
<h2>Humidity : $humidity %</h2>
<h2>Tempareture_min : ".k2c($temp_min)." C</h2>
<h2>Tempareture_max : ".k2c($temp_max)." C</h2>
<h2>wind Speed : $speed KPH</h2>
<h2>wind angle : $degree degree</h2>";
	
    //print_r($json_obj);
?>


