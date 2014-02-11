<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LocationControl.ascx.cs"
    Inherits="GiaPhuc.Controls.LocationControl" %>
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type="text/javascript">
    var map; var infowindow;
    function InitializeMap() {
        var latlng = new window.google.maps.LatLng(10.759344, 106.648292);
        var myOptions =
        {
            zoom: 15,
            center: latlng,
            mapTypeId: window.google.maps.MapTypeId.ROADMAP
        };
        map = new window.google.maps.Map(document.getElementById("map"), myOptions);
    }


    function markicons() {

        InitializeMap();

        var ltlng = [];

        ltlng.push(new window.google.maps.LatLng(10.759344, 106.648292));
        //ltlng.push(new window.google.maps.LatLng(10.81948, 106.625054));
        //        ltlng.push(new google.maps.LatLng(15.24, 77.16));

        map.setCenter(ltlng[0]);
        for (var i = 0; i <= ltlng.length; i++) {
            var marker = new window.google.maps.Marker({
                map: map,
                position: ltlng[i]
            });
            (function (i, marker) {

                window.google.maps.event.addListener(marker, 'click', function () {

                    if (!infowindow) {
                        infowindow = new window.google.maps.InfoWindow();
                    }

                    infowindow.setContent("CỬA HÀNG TINH TẾ (Nice Store)<br />174/47 Thái Phiên, P8, Q11");

                    infowindow.open(map, marker);

                });

            })(i, marker);

        }

    }

    window.onload = markicons; 

</script>
<div id="map" style="width: 100%; height: 500px; margin-top: 5px;">
</div>
