using Script.CoreUObject;
using Script.Library;
using Script.InputCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintInputAxisKeyDelegateBinding")]
	public partial class FBlueprintInputAxisKeyDelegateBinding : FBlueprintInputDelegateBinding, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlueprintInputAxisKeyDelegateBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintInputAxisKeyDelegateBinding()
		{
		}

		public static bool operator ==(FBlueprintInputAxisKeyDelegateBinding A, FBlueprintInputAxisKeyDelegateBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintInputAxisKeyDelegateBinding A, FBlueprintInputAxisKeyDelegateBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintInputAxisKeyDelegateBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FKey AxisKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AxisKey, __ReturnBuffer);

					return *(FKey*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AxisKey, __InBuffer);
				}
			}
		}

		public FName FunctionNameToBind
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionNameToBind, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionNameToBind, __InBuffer);
				}
			}
		}

		private static uint __AxisKey = 0;

		private static uint __FunctionNameToBind = 0;

	}
}