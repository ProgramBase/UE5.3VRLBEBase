using Script.CoreUObject;
using Script.Library;

namespace Script.MessagingRpc
{
	[PathName("/Script/MessagingRpc.MessageRpcProgress")]
	public partial class FMessageRpcProgress : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MessagingRpc.MessageRpcProgress");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMessageRpcProgress() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMessageRpcProgress() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMessageRpcProgress A, FMessageRpcProgress B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMessageRpcProgress A, FMessageRpcProgress B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMessageRpcProgress;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Completion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Completion, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Completion, __InBuffer);
				}
			}
		}

		public FGuid CallId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CallId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CallId, __InBuffer);
				}
			}
		}

		public FString StatusText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StatusText, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StatusText, __InBuffer);
				}
			}
		}

		private static uint __Completion = 0;

		private static uint __CallId = 0;

		private static uint __StatusText = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}