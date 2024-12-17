using Script.CoreUObject;
using Script.Library;
using Script.Slate;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintInputKeyDelegateBinding")]
	public partial class FBlueprintInputKeyDelegateBinding : FBlueprintInputDelegateBinding, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlueprintInputKeyDelegateBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintInputKeyDelegateBinding()
		{
		}

		public static bool operator ==(FBlueprintInputKeyDelegateBinding A, FBlueprintInputKeyDelegateBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintInputKeyDelegateBinding A, FBlueprintInputKeyDelegateBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintInputKeyDelegateBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FInputChord InputChord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputChord, __ReturnBuffer);

					return *(FInputChord*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputChord, __InBuffer);
				}
			}
		}

		public EInputEvent InputKeyEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputKeyEvent, __ReturnBuffer);

					return *(EInputEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputKeyEvent, __InBuffer);
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

		private static uint __InputChord = 0;

		private static uint __InputKeyEvent = 0;

		private static uint __FunctionNameToBind = 0;

	}
}