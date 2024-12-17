using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithPointLightComponentTemplate")]
	public partial class UDatasmithPointLightComponentTemplate : UDatasmithObjectTemplate, IStaticClass
	{
		public ELightUnits IntensityUnits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntensityUnits, __ReturnBuffer);

					return *(ELightUnits*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntensityUnits, __InBuffer);
				}
			}
		}

		public float SourceRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceRadius, __InBuffer);
				}
			}
		}

		public float SourceLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceLength, __InBuffer);
				}
			}
		}

		public float AttenuationRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DatasmithContent.DatasmithPointLightComponentTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __IntensityUnits = 0;

		private static uint __SourceRadius = 0;

		private static uint __SourceLength = 0;

		private static uint __AttenuationRadius = 0;
	}
}