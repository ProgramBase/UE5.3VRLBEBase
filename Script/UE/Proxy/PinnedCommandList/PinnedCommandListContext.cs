using Script.CoreUObject;
using Script.Library;

namespace Script.PinnedCommandList
{
	[PathName("/Script/PinnedCommandList.PinnedCommandListContext")]
	public partial class FPinnedCommandListContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PinnedCommandList.PinnedCommandListContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPinnedCommandListContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPinnedCommandListContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPinnedCommandListContext A, FPinnedCommandListContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPinnedCommandListContext A, FPinnedCommandListContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPinnedCommandListContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public TArray<FPinnedCommandListCommand> Commands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Commands, __ReturnBuffer);

					return *(TArray<FPinnedCommandListCommand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Commands, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __Commands = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}