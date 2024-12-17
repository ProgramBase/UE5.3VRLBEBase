using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetCompilerOptions")]
	public partial class FWidgetCompilerOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMGEditor.WidgetCompilerOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetCompilerOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWidgetCompilerOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWidgetCompilerOptions A, FWidgetCompilerOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetCompilerOptions A, FWidgetCompilerOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetCompilerOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAllowBlueprintTick
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowBlueprintTick, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowBlueprintTick, __InBuffer);
				}
			}
		}

		public bool bAllowBlueprintPaint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowBlueprintPaint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowBlueprintPaint, __InBuffer);
				}
			}
		}

		public EPropertyBindingPermissionLevel PropertyBindingRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyBindingRule, __ReturnBuffer);

					return *(EPropertyBindingPermissionLevel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyBindingRule, __InBuffer);
				}
			}
		}

		public TArray<TSoftClassPtr<UWidgetCompilerRule>> Rules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rules, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UWidgetCompilerRule>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rules, __InBuffer);
				}
			}
		}

		private static uint __bAllowBlueprintTick = 0;

		private static uint __bAllowBlueprintPaint = 0;

		private static uint __PropertyBindingRule = 0;

		private static uint __Rules = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}