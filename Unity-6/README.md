# Unity-BasicVehiclesControl_ForSyntyCity

Description:
------------


Create basic Vehicle Controllers for your Unity projects using vehicle models
from Synty Polygon City Asset.

 Note: As this uses the vehicles from such and due to licensing such said vehicles cannot be included in this repository obviously, so, as such the provided scripts and instructions thus require having / purchasing the Synty Polygon City Asset: https://assetstore.unity.com/packages/3d/environments/urban/polygon-city-low-poly-3d-art-by-synty-95214


Synty City Vehicles (total: 32)
-------------------------------

* Ambulance (total: 4)
* Police Cruiser (total: 4)
* Muscle Car (total: 4)
* Sedan Large (total: 4)
* Sedan Medium (total: 4)
* Sedan Small (total: 4)
* Taxi (total: 4)
* Van (total: 4)


![Preview](https://raw.githubusercontent.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/refs/heads/main/Previews/All/PolygonCity-Vehicles.png)


Release Intentions Note:
------------------------

The intention of these releases due to only being scripts for usage with models one must already own or opt to purchase and as such was known that one could not release such models with the package here the intent was to provide basic vehicle functionality as a start point as fully functional in terms of an opinion of basic but leave out optional continuances in the hopes that these will be used as starting points for folks to continue on with and improve upon. Now, some of the things intentionally left out, umm, while all simply easy to add, lets see: say, audio sources, audio clips, particle systems for exhausts as leaving these initializations of such aforementioned suggestions out was indeed intentional in the hopes that the end user will continue to add those as desired and continue to improve upon the provided start points. Also note that while yes, these are great hints, tips and or suggestions, if you were thinking say of what to add next, please note though, that is not to say if and or when I may find myself to have free time say I just may or may not opt to add such or some of such at later dates if desire or free time allows. Another thing to note is that I intentionally left out adding a fuel system to these at this time because again the intent was to provide basic functional vehicle controllers as starting points. 

NOTE: This project was developed while / for using Unity 6 


Vehicles Currently "Completed" & Included:
------------------------------------------

* Ambulance (100% completed)
* PoliceCruiser (100% completed)
* Van (100% completed)
* Taxi (100% completed)
* MuscleCar (100% completed)
* SedanLarge (100% completed)
* SedanMedium (100% completed)
* SedanSmall (100% completed)



Other Currently "Completed" & Included:
---------------------------------------


* Player & Vehicles Compass


 
 
Other Current Possibles "In Progress" & Not Yet Included:
---------------------------------------------------------

Possible future additions: (if and or when my limited free time and desire may allow)

* Gas Station / Fuel System (0% Completed) coming TBA...
* Engine Audio (0% Completed) coming TBA...
* Horn Audio (0% Completed) coming TBA...
* Reverse Beeps Audio (0% Completed) coming TBA...
* Siren Audio (0% Completed) coming TBA...
* Exhaust Particles (0% Completed) coming TBA...
* Mesh Deformation (0% Completed) coming TBA...
* Related Documentation(s) for above (0% completed) coming TBA...



Player Controls: 
----------------


  Note: The following found below are related to the provided playercontrol script for usage example if say using vehicle entry script.


* Player Forward:   W
* Player Reverse:   S
* Player Left:      A
* Player Right:     D
* Player Jump:      Space
* Player Sprint:    Left Shift


Vehicle Controls: 
-----------------


  Note: The following below are related to both variations either standalone vehicle controller usage and entry script usage.


* Vehicle Forward:  W
* Vehicle Reverse:  S
* Turn Left:        A
* Turn Right:       D
* Apply Brake:      Space


Entry Script: 


  Note: The following found below are specific only when entry script is applied.


* Enter Vehicle:    E
* Exit Vehicle:     F

Manual Setup Instruction:
-------------------------

Simply follow the documentation instruction linkages for manual setups found below.


PlayerControl:
--------------


* Example player control documentation: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/PlayerControl/Documentation/PlayerControl-Documentation.txt




Unity 6 Bug (Related to Wheel Colliders and Center of Gravity Offset)
----------------------------------------------------------------------


NOTE: There is a bug in Unity 6 versions prior to version Unity 6
(6000.025f1) that affects wheel colliders and center of gravity offset.
This bug was reported and an official fix has thus after such been
provided. 

Prior to that fixed version if you have not yet upgraded to the fixed version
we can still provide a temporary resolution file to add to your vehicle to
sort this out.


* Temporary Unity 6 Bug Resolution: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Temporary-Resolution/Unity-6-Temporary-Resolve-Bug.txt


ATTENTION!!: This bug has been fixed in Unity 6 (6000.025f1) thus this
temporary resolution is not needed if you upgraded or ugrade to that
version+!


Vehicles Control:
-----------------


* All vehicles in scene with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Documentation/AllVehicleControllers-wEntry-Documentation.txt

* All vehicles types with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Documentation/AllController-Types-wEntry-Documentation.txt



Ambulance: (total: 4)
--------------------------


* Ambulance 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance01/Documentation/Ambulance01Controller-Only-Documentation.txt

* Ambulance 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance01/Documentation/Ambulance01Controller-Only-Speedometer-Documentation.txt

* Ambulance 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance01/Documentation/Ambulance01Controller-wEntry-Documentation.txt

* Ambulance 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance01/Documentation/Ambulance01Controller-Speedometer-Documentation.txt

* Ambulance 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance02/Documentation/Ambulance02Controller-Only-Documentation.txt

* Ambulance 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance02/Documentation/Ambulance02Controller-Only-Speedometer-Documentation.txt

* Ambulance 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance02/Documentation/Ambulance02Controller-wEntry-Documentation.txt

* Ambulance 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance02/Documentation/Ambulance02Controller-Speedometer-Documentation.txt

* Ambulance 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance03/Documentation/Ambulance03Controller-Only-Documentation.txt

* Ambulance 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance03/Documentation/Ambulance03Controller-Only-Speedometer-Documentation.txt

* Ambulance 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance03/Documentation/Ambulance03Controller-wEntry-Documentation.txt

* Ambulance 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance03/Documentation/Ambulance03Controller-Speedometer-Documentation.txt

* Ambulance 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance04/Documentation/Ambulance04Controller-Only-Documentation.txt

* Ambulance 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance04/Documentation/Ambulance04Controller-Only-Speedometer-Documentation.txt

* Ambulance 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance04/Documentation/Ambulance04Controller-wEntry-Documentation.txt

* Ambulance 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Ambulance04/Documentation/Ambulance04Controller-Speedometer-Documentation.txt

* All Ambulances in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Ambulance/Documentation/AllAmbulanceControllers-wEntry-Documentation.txt



Police Cruiser: (total: 4)
--------------------------


* PoliceCruiser 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser01/Documentation/PoliceCruiser01Controller-Only-Documentation.txt

* PoliceCruiser 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser01/Documentation/PoliceCruiser01Controller-Only-Speedometer-Documentation.txt

* PoliceCruiser 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser01/Documentation/PoliceCruiser01Controller-wEntry-Documentation.txt

* PoliceCruiser 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser01/Documentation/PoliceCruiser01Controller-Speedometer-Documentation.txt

* PoliceCruiser 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser02/Documentation/PoliceCruiser02Controller-Only-Documentation.txt

* PoliceCruiser 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser02/Documentation/PoliceCruiser02Controller-Only-Speedometer-Documentation.txt

* PoliceCruiser 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser02/Documentation/PoliceCruiser02Controller-wEntry-Documentation.txt

* PoliceCruiser 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser02/Documentation/PoliceCruiser02Controller-Speedometer-Documentation.txt

* PoliceCruiser 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser03/Documentation/PoliceCruiser03Controller-Only-Documentation.txt

* PoliceCruiser 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser03/Documentation/PoliceCruiser03Controller-Only-Speedometer-Documentation.txt

* PoliceCruiser 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser03/Documentation/PoliceCruiser03Controller-wEntry-Documentation.txt

* PoliceCruiser 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser03/Documentation/PoliceCruiser03Controller-Speedometer-Documentation.txt

* PoliceCruiser 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser04/Documentation/PoliceCruiser04Controller-Only-Documentation.txt

* PoliceCruiser 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser04/Documentation/PoliceCruiser04Controller-Only-Speedometer-Documentation.txt

* PoliceCruiser 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser04/Documentation/PoliceCruiser04Controller-wEntry-Documentation.txt

* PoliceCruiser 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/PoliceCruiser04/Documentation/PoliceCruiser04Controller-Speedometer-Documentation.txt

* All Police Cruisers in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/PoliceCruiser/Documentation/AllPoliceCruiserControllers-wEntry-Documentation.txt


Muscle Car: (total: 4)
--------------------------


* MuscleCar 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar01/Documentation/MuscleCar01Controller-Only-Documentation.txt

* MuscleCar 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar01/Documentation/MuscleCar01Controller-Only-Speedometer-Documentation.txt

* MuscleCar 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar01/Documentation/MuscleCar01Controller-wEntry-Documentation.txt

* MuscleCar 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar01/Documentation/MuscleCar01Controller-Speedometer-Documentation.txt

* MuscleCar 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar02/Documentation/MuscleCar02Controller-Only-Documentation.txt

* MuscleCar 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar02/Documentation/MuscleCar02Controller-Only-Speedometer-Documentation.txt

* MuscleCar 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar02/Documentation/MuscleCar02Controller-wEntry-Documentation.txt

* MuscleCar 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar02/Documentation/MuscleCar02Controller-Speedometer-Documentation.txt

* MuscleCar 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar03/Documentation/MuscleCar03Controller-Only-Documentation.txt

* MuscleCar 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar03/Documentation/MuscleCar03Controller-Only-Speedometer-Documentation.txt

* MuscleCar 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar03/Documentation/MuscleCar03Controller-wEntry-Documentation.txt

* MuscleCar 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar03/Documentation/MuscleCar03Controller-Speedometer-Documentation.txt

* MuscleCar 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar04/Documentation/MuscleCar04Controller-Only-Documentation.txt

* MuscleCar 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar04/Documentation/MuscleCar04Controller-Only-Speedometer-Documentation.txt

* MuscleCar 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar04/Documentation/MuscleCar04Controller-wEntry-Documentation.txt

* MuscleCar 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/MuscleCar04/Documentation/MuscleCar04Controller-Speedometer-Documentation.txt

* All Muscle Cars in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/MuscleCar/Documentation/AllMuscleCarControllers-wEntry-Documentation.txt


Taxi: (total: 4)
--------------------------


* Taxi 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi01/Documentation/Taxi01Controller-Only-Documentation.txt

* Taxi 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi01/Documentation/Taxi01Controller-Only-Speedometer-Documentation.txt

* Taxi 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi01/Documentation/Taxi01Controller-wEntry-Documentation.txt

* Taxi 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi01/Documentation/Taxi01Controller-Speedometer-Documentation.txt

* Taxi 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi02/Documentation/Taxi02Controller-Only-Documentation.txt

* Taxi 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi02/Documentation/Taxi02Controller-Only-Speedometer-Documentation.txt

* Taxi 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi02/Documentation/Taxi02Controller-wEntry-Documentation.txt

* Taxi 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi02/Documentation/Taxi02Controller-Speedometer-Documentation.txt

* Taxi 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi03/Documentation/Taxi03Controller-Only-Documentation.txt

* Taxi 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi03/Documentation/Taxi03Controller-Only-Speedometer-Documentation.txt

* Taxi 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi03/Documentation/Taxi03Controller-wEntry-Documentation.txt

* Taxi 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi03/Documentation/Taxi03Controller-Speedometer-Documentation.txt

* Taxi 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi04/Documentation/Taxi04Controller-Only-Documentation.txt

* Taxi 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi04/Documentation/Taxi04Controller-Only-Speedometer-Documentation.txt

* Taxi 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi04/Documentation/Taxi04Controller-wEntry-Documentation.txt

* Taxi 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Taxi04/Documentation/Taxi04Controller-Speedometer-Documentation.txt

* All Taxis in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Taxi/Documentation/AllTaxiControllers-wEntry-Documentation.txt


Van: (total: 4)
--------------------------


* Van 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van01/Documentation/Van01Controller-Only-Documentation.txt

* Van 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van01/Documentation/Van01Controller-Only-Speedometer-Documentation.txt

* Van 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van01/Documentation/Van01Controller-wEntry-Documentation.txt

* Van 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van01/Documentation/Van01Controller-Speedometer-Documentation.txt

* Van 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van02/Documentation/Van02Controller-Only-Documentation.txt

* Van 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van02/Documentation/Van02Controller-Only-Speedometer-Documentation.txt

* Van 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van02/Documentation/Van02Controller-wEntry-Documentation.txt

* Van 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van02/Documentation/Van02Controller-Speedometer-Documentation.txt

* Van 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van03/Documentation/Van03Controller-Only-Documentation.txt

* Van 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van03/Documentation/Van03Controller-Only-Speedometer-Documentation.txt

* Van 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van03/Documentation/Van03Controller-wEntry-Documentation.txt

* Van 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van03/Documentation/Van03Controller-Speedometer-Documentation.txt

* Van 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van04/Documentation/Van04Controller-Only-Documentation.txt

* Van 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van04/Documentation/Van04Controller-Only-Speedometer-Documentation.txt

* Van 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van04/Documentation/Van04Controller-wEntry-Documentation.txt

* Van 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Van04/Documentation/Van04Controller-Speedometer-Documentation.txt

* All Vans in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/Van/Documentation/AllVanControllers-wEntry-Documentation.txt


Sedan Large: (total: 4)
--------------------------


* SedanLarge 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge01/Documentation/SedanLarge01Controller-Only-Documentation.txt

* SedanLarge 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge01/Documentation/SedanLarge01Controller-Only-Speedometer-Documentation.txt

* SedanLarge 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge01/Documentation/SedanLarge01Controller-wEntry-Documentation.txt

* SedanLarge 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge01/Documentation/SedanLarge01Controller-Speedometer-Documentation.txt

* SedanLarge 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge02/Documentation/SedanLarge02Controller-Only-Documentation.txt

* SedanLarge 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge02/Documentation/SedanLarge02Controller-Only-Speedometer-Documentation.txt

* SedanLarge 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge02/Documentation/SedanLarge02Controller-wEntry-Documentation.txt

* SedanLarge 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge02/Documentation/SedanLarge02Controller-Speedometer-Documentation.txt

* SedanLarge 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge03/Documentation/SedanLarge03Controller-Only-Documentation.txt

* SedanLarge 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge03/Documentation/SedanLarge03Controller-Only-Speedometer-Documentation.txt

* SedanLarge 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge03/Documentation/SedanLarge03Controller-wEntry-Documentation.txt

* SedanLarge 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge03/Documentation/SedanLarge03Controller-Speedometer-Documentation.txt

* SedanLarge 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge04/Documentation/SedanLarge04Controller-Only-Documentation.txt

* SedanLarge 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge04/Documentation/SedanLarge04Controller-Only-Speedometer-Documentation.txt

* SedanLarge 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge04/Documentation/SedanLarge04Controller-wEntry-Documentation.txt

* SedanLarge 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/SedanLarge04/Documentation/SedanLarge04Controller-Speedometer-Documentation.txt

* All Sedan Larges in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanLarge/Documentation/AllSedanLargeControllers-wEntry-Documentation.txt


Sedan Medium: (total: 4)
--------------------------


* SedanMedium 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium01/Documentation/SedanMedium01Controller-Only-Documentation.txt

* SedanMedium 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium01/Documentation/SedanMedium01Controller-Only-Speedometer-Documentation.txt

* SedanMedium 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium01/Documentation/SedanMedium01Controller-wEntry-Documentation.txt

* SedanMedium 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium01/Documentation/SedanMedium01Controller-Speedometer-Documentation.txt

* SedanMedium 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium02/Documentation/SedanMedium02Controller-Only-Documentation.txt

* SedanMedium 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium02/Documentation/SedanMedium02Controller-Only-Speedometer-Documentation.txt

* SedanMedium 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium02/Documentation/SedanMedium02Controller-wEntry-Documentation.txt

* SedanMedium 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium02/Documentation/SedanMedium02Controller-Speedometer-Documentation.txt

* SedanMedium 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium03/Documentation/SedanMedium03Controller-Only-Documentation.txt

* SedanMedium 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium03/Documentation/SedanMedium03Controller-Only-Speedometer-Documentation.txt

* SedanMedium 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium03/Documentation/SedanMedium03Controller-wEntry-Documentation.txt

* SedanMedium 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium03/Documentation/SedanMedium03Controller-Speedometer-Documentation.txt

* SedanMedium 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium04/Documentation/SedanMedium04Controller-Only-Documentation.txt

* SedanMedium 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium04/Documentation/SedanMedium04Controller-Only-Speedometer-Documentation.txt

* SedanMedium 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium04/Documentation/SedanMedium04Controller-wEntry-Documentation.txt

* SedanMedium 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/SedanMedium04/Documentation/SedanMedium04Controller-Speedometer-Documentation.txt

* All Sedan Mediums in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanMedium/Documentation/AllSedanMediumControllers-wEntry-Documentation.txt


Sedan Small: (total: 4)
--------------------------


* SedanSmall 01 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall01/Documentation/SedanSmall01Controller-Only-Documentation.txt

* SedanSmall 01 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall01/Documentation/SedanSmall01Controller-Only-Speedometer-Documentation.txt

* SedanSmall 01 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall01/Documentation/SedanSmall01Controller-wEntry-Documentation.txt

* SedanSmall 01 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall01/Documentation/SedanSmall01Controller-Speedometer-Documentation.txt

* SedanSmall 02 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall02/Documentation/SedanSmall02Controller-Only-Documentation.txt

* SedanSmall 02 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall02/Documentation/SedanSmall02Controller-Only-Speedometer-Documentation.txt

* SedanSmall 02 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall02/Documentation/SedanSmall02Controller-wEntry-Documentation.txt

* SedanSmall 02 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall02/Documentation/SedanSmall02Controller-Speedometer-Documentation.txt

* SedanSmall 03 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall03/Documentation/SedanSmall03Controller-Only-Documentation.txt

* SedanSmall 03 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall03/Documentation/SedanSmall03Controller-Only-Speedometer-Documentation.txt

* SedanSmall 03 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall03/Documentation/SedanSmall03Controller-wEntry-Documentation.txt

* SedanSmall 03 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall03/Documentation/SedanSmall03Controller-Speedometer-Documentation.txt

* SedanSmall 04 Controller only in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall04/Documentation/SedanSmall04Controller-Only-Documentation.txt

* SedanSmall 04 Controller only in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall04/Documentation/SedanSmall04Controller-Only-Speedometer-Documentation.txt

* SedanSmall 04 Controller only with entry in scene setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall04/Documentation/SedanSmall04Controller-wEntry-Documentation.txt

* SedanSmall 04 Controller only with entry in scene setup add speedometer: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/SedanSmall04/Documentation/SedanSmall04Controller-Speedometer-Documentation.txt

* All Sedan Smalls in scene with entry setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/VehiclesControl/SedanSmall/Documentation/AllSedanSmallControllers-wEntry-Documentation.txt



Player and Vehicles Compass:
----------------------------


All vehicles with entry:

* All Vehicles with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Documentation/Compass-Documentation.txt

* All Vehicles types in scene with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Documentation/Compass-2-Documentation.txt

* All Ambulances with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Compass-Documentation.txt

* All Muscle Cars with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/Compass-Documentation.txt

* All Police Cruisers with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCruiser/Documentation/Compass-Documentation.txt

* All Sedan Larges with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/Compass-Documentation.txt

* All Sedan Mediums with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/Compass-Documentation.txt

* All Sedan Smalls with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/Compass-Documentation.txt

* All Taxis with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Compass-Documentation.txt

* All Vans with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Compass-Documentation.txt


Individual Vehicles:

Ambulance:

Vehicles with entry:


* Ambulance 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance01-Individual-Compass-Documentation.txt

* Ambulance 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance02-Individual-Compass-Documentation.txt

* Ambulance 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance03-Individual-Compass-Documentation.txt

* Ambulance 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Ambulance 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance01-Controller-Only-Compass-Documentation.txt

* Ambulance 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance02-Controller-Only-Compass-Documentation.txt

* Ambulance 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance03-Controller-Only-Compass-Documentation.txt

* Ambulance 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Ambulance/Documentation/Ambulance04-Controller-Only-Compass-Documentation.txt


Muscle Car:

Vehicles with entry:

* Muscle Car 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar01-Individual-Compass-Documentation.txt

* Muscle Car 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar02-Individual-Compass-Documentation.txt

* Muscle Car 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar03-Individual-Compass-Documentation.txt

* Muscle Car 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Muscle Car 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar01-Controller-Only-Compass-Documentation.txt

* Muscle Car 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar02-Controller-Only-Compass-Documentation.txt

* Muscle Car 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar03-Controller-Only-Compass-Documentation.txt

* Muscle Car 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/MuscleCar/Documentation/MuscleCar04-Controller-Only-Compass-Documentation.txt



Police Cruiser:

Vehicles with entry:

* Police Charger 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCharger/Documentation/PoliceCharger01-Individual-Compass-Documentation.txt

* Police Charger 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCharger/Documentation/PoliceCharger02-Individual-Compass-Documentation.txt

* Police Charger 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCharger/Documentation/PoliceCharger03-Individual-Compass-Documentation.txt

* Police Charger 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCharger/Documentation/PoliceCharger04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Police Cruiser 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCruiser/Documentation/PoliceCruiser01-Controller-Only-Compass-Documentation.txt

* Police Cruiser 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCruiser/Documentation/PoliceCruiser02-Controller-Only-Compass-Documentation.txt

* Police Cruiser 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCruiser/Documentation/PoliceCruiser03-Controller-Only-Compass-Documentation.txt

* Police Cruiser 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/PoliceCruiser/Documentation/PoliceCruiser04-Controller-Only-Compass-Documentation.txt



Sedan Large:

Vehicles with entry:

* Sedan Large 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge01-Individual-Compass-Documentation.txt

* Sedan Large 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge02-Individual-Compass-Documentation.txt

* Sedan Large 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge03-Individual-Compass-Documentation.txt

* Sedan Large 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Sedan Large 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge01-Controller-Only-Compass-Documentation.txt

* Sedan Large 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge02-Controller-Only-Compass-Documentation.txt

* Sedan Large 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge03-Controller-Only-Compass-Documentation.txt

* Sedan Large 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanLarge/Documentation/SedanLarge04-Controller-Only-Compass-Documentation.txt




Sedan Medium:

Vehicles with entry:

* Sedan Medium 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium01-Individual-Compass-Documentation.txt

* Sedan Medium 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium02-Individual-Compass-Documentation.txt

* Sedan Medium 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium03-Individual-Compass-Documentation.txt

* Sedan Medium 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Sedan Medium 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium01-Controller-Only-Compass-Documentation.txt

* Sedan Medium 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium02-Controller-Only-Compass-Documentation.txt

* Sedan Medium 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium03-Controller-Only-Compass-Documentation.txt

* Sedan Medium 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanMedium/Documentation/SedanMedium04-Controller-Only-Compass-Documentation.txt



Sedan Small:

Vehicles with entry:

* Sedan Small 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall01-Individual-Compass-Documentation.txt

* Sedan Small 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall02-Individual-Compass-Documentation.txt

* Sedan Small 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall03-Individual-Compass-Documentation.txt

* Sedan Small 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Sedan Small 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall01-Controller-Only-Compass-Documentation.txt

* Sedan Small 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall02-Controller-Only-Compass-Documentation.txt

* Sedan Small 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall03-Controller-Only-Compass-Documentation.txt

* Sedan Small 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/SedanSmall/Documentation/SedanSmall04-Controller-Only-Compass-Documentation.txt



Taxi:

Vehicles with entry:

* Taxi 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi01-Individual-Compass-Documentation.txt

* Taxi 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi02-Individual-Compass-Documentation.txt

* Taxi 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi03-Individual-Compass-Documentation.txt

* Taxi 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Taxi 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi01-Controller-Only-Compass-Documentation.txt

* Taxi 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi02-Controller-Only-Compass-Documentation.txt

* Taxi 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi03-Controller-Only-Compass-Documentation.txt

* Taxi 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Taxi/Documentation/Taxi04-Controller-Only-Compass-Documentation.txt


Van:

Vehicles with entry:

* Van 01 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van01-Individual-Compass-Documentation.txt

* Van 02 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van02-Individual-Compass-Documentation.txt

* Van 03 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van03-Individual-Compass-Documentation.txt

* Van 04 with entry Player and Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van04-Individual-Compass-Documentation.txt


Vehicles without entry:

* Van 01 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van01-Controller-Only-Compass-Documentation.txt

* Van 02 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van02-Controller-Only-Compass-Documentation.txt

* Van 03 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van03-Controller-Only-Compass-Documentation.txt

* Van 04 without entry Vehicle Compass setup: https://github.com/deathwatchgaming/Unity-BasicVehiclesControl_ForSyntyCity/blob/main/Unity-6/Assets/NavigationControl/Compass/Scripts/Van/Documentation/Van04-Controller-Only-Compass-Documentation.txt
