using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintInputAxisDelegateBinding")]
	public partial class FBlueprintInputAxisDelegateBinding : FBlueprintInputDelegateBinding, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlueprintInputAxisDelegateBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintInputAxisDelegateBinding()
		{
		}

		public static bool operator ==(FBlueprintInputAxisDelegateBinding A, FBlueprintInputAxisDelegateBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintInputAxisDelegateBinding A, FBlueprintInputAxisDelegateBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintInputAxisDelegateBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName InputAxisName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputAxisName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputAxisName, __InBuffer);
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

		private static uint __InputAxisName = 0;

		private static uint __FunctionNameToBind = 0;

	}
}