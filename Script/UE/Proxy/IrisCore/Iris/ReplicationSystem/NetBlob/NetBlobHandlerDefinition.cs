using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetBlobHandlerDefinition")]
	public partial class FNetBlobHandlerDefinition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/IrisCore.NetBlobHandlerDefinition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNetBlobHandlerDefinition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNetBlobHandlerDefinition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNetBlobHandlerDefinition A, FNetBlobHandlerDefinition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNetBlobHandlerDefinition A, FNetBlobHandlerDefinition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNetBlobHandlerDefinition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassName, __InBuffer);
				}
			}
		}

		private static uint __ClassName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}