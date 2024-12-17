using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerExtensionConfig")]
	public partial class FGameplayDebuggerExtensionConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerExtensionConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerExtensionConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerExtensionConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerExtensionConfig A, FGameplayDebuggerExtensionConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerExtensionConfig A, FGameplayDebuggerExtensionConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerExtensionConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ExtensionName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExtensionName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExtensionName, __InBuffer);
				}
			}
		}

		public EGameplayDebuggerOverrideMode UseExtension
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UseExtension, __ReturnBuffer);

					return *(EGameplayDebuggerOverrideMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UseExtension, __InBuffer);
				}
			}
		}

		public TArray<FGameplayDebuggerInputConfig> InputHandlers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputHandlers, __ReturnBuffer);

					return *(TArray<FGameplayDebuggerInputConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputHandlers, __InBuffer);
				}
			}
		}

		private static uint __ExtensionName = 0;

		private static uint __UseExtension = 0;

		private static uint __InputHandlers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}