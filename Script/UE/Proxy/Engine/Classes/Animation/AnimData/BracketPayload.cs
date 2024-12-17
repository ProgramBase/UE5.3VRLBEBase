using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BracketPayload")]
	public partial class FBracketPayload : FEmptyPayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BracketPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBracketPayload()
		{
		}

		public static bool operator ==(FBracketPayload A, FBracketPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBracketPayload A, FBracketPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBracketPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Description
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Description, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Description, __InBuffer);
				}
			}
		}

		private static uint __Description = 0;

	}
}