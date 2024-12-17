using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugCameraControllerSettingsViewModeIndex")]
	public partial class FDebugCameraControllerSettingsViewModeIndex : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DebugCameraControllerSettingsViewModeIndex");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDebugCameraControllerSettingsViewModeIndex() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDebugCameraControllerSettingsViewModeIndex() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDebugCameraControllerSettingsViewModeIndex A, FDebugCameraControllerSettingsViewModeIndex B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDebugCameraControllerSettingsViewModeIndex A, FDebugCameraControllerSettingsViewModeIndex B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDebugCameraControllerSettingsViewModeIndex;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EViewModeIndex ViewModeIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ViewModeIndex, __ReturnBuffer);

					return *(EViewModeIndex*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ViewModeIndex, __InBuffer);
				}
			}
		}

		private static uint __ViewModeIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}