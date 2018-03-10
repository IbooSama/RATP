<?php

$ratpFile = file_get_contents("./positions-geographiques-des-stations-du-reseau-ratp.json");
$ratpStations = array_column(json_decode($ratpFile, true), 'fields');

$metroFile = file_get_contents("./grstations.json");
$metro = json_decode($metroFile, true);

$outPutFile = './output';

//var_dump($metro[0]);
//var_dump($stations[1]['stop_name']);exit;

foreach ($metro as $lineKey => $line) {
	foreach ($line['stations'] as $key => $metroStation) {
		$metro[$lineKey]['stations'][$key] = array_merge($metroStation, getStationInfoFromRatp($metroStation, $ratpStations));
	}
}

foreach ($metro as $line) {
	foreach ($line['stations'] as $station) {
		$output = "new Station\n{\n    Name = \"" . $station["name"]
		. "\",\n    Latitude = " . $station["latitude"]
		. ",\n    Longitude = " . $station["longitude"]
		. ",\n    Line = \"" . $line['line']
		. "\"\n},\n";
		file_put_contents($outPutFile, $output, FILE_APPEND | LOCK_EX);
	}
}

function getStationInfoFromRatp($metroStation, $ratpStations)
{
	foreach ($ratpStations as $station) {
		if (removeAccents($station["stop_name"]) == removeAccents($metroStation["name"])) {
			return [
				"latitude" => $station["stop_lat"],
				"longitude" => $station["stop_lon"]
			];
		}
	}
	return [
		"latitude" => 0,
		"longitude" => 0
	];
}


function removeAccents($string) {
    return strtolower(trim(preg_replace('~[^0-9a-z]+~i', '-', preg_replace('~&([a-z]{1,2})(acute|cedil|circ|grave|lig|orn|ring|slash|th|tilde|uml);~i', '$1', htmlentities($string, ENT_QUOTES, 'UTF-8'))), ' '));
}
?>
