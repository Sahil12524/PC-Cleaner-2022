bcdedit /set useplatformclock false
bcdedit /set useplatformtick yes
bcdedit /set disabledynamictick yes
bcdedit /set x2apicpolicy Enable
bcdedit /set configaccesspolicy Default
bcdedit /set MSI Default
bcdedit /set usephysicaldestination No
bcdedit /set usefirmwarepcisettings No
bcdedit /set tscsyncpolicy Enhanced
bcdedit /deletevalue useplatformclock