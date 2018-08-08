using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSecurityDetector.Services
{
    public class ValidateFlashDrive
    {
		public static bool _GetFlashDrives()
		{
			DriveInfo[] mydrives = DriveInfo.GetDrives();

			foreach (DriveInfo mydrive in mydrives)
			{
				if (mydrive.DriveType == DriveType.Removable)
				{
					if (mydrive.IsReady == true)
					{
						if (mydrive.VolumeLabel == "WALLETHOST")
						{
							//Codes for Read WalletConfiguration.json to validate USB HashKey , and Validate USB Configuration



							return true;

						}

						continue;
					}

					continue;

				}

				continue;
			}

			return false;
		}


	}
}
