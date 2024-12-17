using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;
using Script.MovieSceneTools;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.RigSpacePickerBakeSettings")]
	public partial class FRigSpacePickerBakeSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.RigSpacePickerBakeSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigSpacePickerBakeSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigSpacePickerBakeSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigSpacePickerBakeSettings A, FRigSpacePickerBakeSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigSpacePickerBakeSettings A, FRigSpacePickerBakeSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigSpacePickerBakeSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigElementKey TargetSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetSpace, __ReturnBuffer);

					return *(FRigElementKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetSpace, __InBuffer);
				}
			}
		}

		public FBakingAnimationKeySettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FBakingAnimationKeySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		private static uint __TargetSpace = 0;

		private static uint __Settings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}