using Script.CoreUObject;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VRButton")]
	public partial class FVRButton : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/VREditor.VRButton");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVRButton() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVRButton() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVRButton A, FVRButton B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVRButton A, FVRButton B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVRButton;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UVREditorWidgetComponent ButtonWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ButtonWidget, __ReturnBuffer);

					return *(UVREditorWidgetComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ButtonWidget, __InBuffer);
				}
			}
		}

		private static uint __ButtonWidget = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}