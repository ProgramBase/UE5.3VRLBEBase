using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ScriptSlateIcon")]
	public partial class FScriptSlateIcon : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ToolMenus.ScriptSlateIcon");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScriptSlateIcon() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FScriptSlateIcon() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FScriptSlateIcon A, FScriptSlateIcon B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScriptSlateIcon A, FScriptSlateIcon B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScriptSlateIcon;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName StyleSetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StyleSetName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StyleSetName, __InBuffer);
				}
			}
		}

		public FName StyleName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StyleName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StyleName, __InBuffer);
				}
			}
		}

		public FName SmallStyleName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SmallStyleName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SmallStyleName, __InBuffer);
				}
			}
		}

		private static uint __StyleSetName = 0;

		private static uint __StyleName = 0;

		private static uint __SmallStyleName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}