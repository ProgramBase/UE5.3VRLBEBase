using Script.CoreUObject;
using Script.Library;

namespace Script.CurveEditor
{
	[PathName("/Script/CurveEditor.CustomColorForSpaceSwitch")]
	public partial class FCustomColorForSpaceSwitch : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CurveEditor.CustomColorForSpaceSwitch");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCustomColorForSpaceSwitch() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCustomColorForSpaceSwitch() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCustomColorForSpaceSwitch A, FCustomColorForSpaceSwitch B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCustomColorForSpaceSwitch A, FCustomColorForSpaceSwitch B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCustomColorForSpaceSwitch;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ControlName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlName, __InBuffer);
				}
			}
		}

		public FLinearColor Color
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Color, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Color, __InBuffer);
				}
			}
		}

		private static uint __ControlName = 0;

		private static uint __Color = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}