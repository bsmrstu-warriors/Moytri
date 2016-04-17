

<!DOCTYPE html>
<html>
  <head>
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no">
    <meta charset="utf-8">
    <title>45° imagery</title>
    <style>
      html, body {
        height: 100%;
        margin: 0;
        padding: 0;
      }
      #map {
        height: 100%;
      }
    </style>
  </head>
  <body>
    <div id="map"></div>
    <script>
	
	var _lat = 23.845568, _lng = 90.402897;
	
	
	
	var hello = {lat: _lat, lng: _lng};
	
      function initMap() {
        var map = new google.maps.Map(document.getElementById('map'), {
          center: hello,
          zoom: 20,
          mapTypeId: google.maps.MapTypeId.SATELLITE
        });
        map.setTilt(45);
      }
	
	
	
	
	
	
	
	
    </script>
    <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAo4vqW4lA3gzVhnvNbcyhzgMcjNxQXnL4&callback=initMap">
    </script>
  </body>
</html>

