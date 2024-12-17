using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithCameraLensSettingsTemplate")]
	public partial class FDatasmithCameraLensSettingsTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithCameraLensSettingsTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithCameraLensSettingsTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithCameraLensSettingsTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithCameraLensSettingsTemplate A, FDatasmithCameraLensSettingsTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithCameraLensSettingsTemplate A, FDatasmithCameraLensSettingsTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithCameraLensSettingsTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MaxFStop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxFStop, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxFStop, __InBuffer);
				}
			}
		}

		private static uint __MaxFStop = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}