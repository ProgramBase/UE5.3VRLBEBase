using Script.CoreUObject;
using Script.Library;
using Script.CinematicCamera;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithCameraFocusSettingsTemplate")]
	public partial class FDatasmithCameraFocusSettingsTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithCameraFocusSettingsTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithCameraFocusSettingsTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithCameraFocusSettingsTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithCameraFocusSettingsTemplate A, FDatasmithCameraFocusSettingsTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithCameraFocusSettingsTemplate A, FDatasmithCameraFocusSettingsTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithCameraFocusSettingsTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ECameraFocusMethod FocusMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FocusMethod, __ReturnBuffer);

					return *(ECameraFocusMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FocusMethod, __InBuffer);
				}
			}
		}

		public float ManualFocusDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ManualFocusDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ManualFocusDistance, __InBuffer);
				}
			}
		}

		private static uint __FocusMethod = 0;

		private static uint __ManualFocusDistance = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}