using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.BlueprintWidgetAnimationDelegateBinding")]
	public partial class FBlueprintWidgetAnimationDelegateBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.BlueprintWidgetAnimationDelegateBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintWidgetAnimationDelegateBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintWidgetAnimationDelegateBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintWidgetAnimationDelegateBinding A, FBlueprintWidgetAnimationDelegateBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintWidgetAnimationDelegateBinding A, FBlueprintWidgetAnimationDelegateBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintWidgetAnimationDelegateBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EWidgetAnimationEvent Action
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Action, __ReturnBuffer);

					return *(EWidgetAnimationEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Action, __InBuffer);
				}
			}
		}

		public FName AnimationToBind
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimationToBind, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimationToBind, __InBuffer);
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

		public FName UserTag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserTag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserTag, __InBuffer);
				}
			}
		}

		private static uint __Action = 0;

		private static uint __AnimationToBind = 0;

		private static uint __FunctionNameToBind = 0;

		private static uint __UserTag = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}