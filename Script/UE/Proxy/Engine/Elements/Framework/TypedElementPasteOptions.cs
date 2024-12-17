using Script.CoreUObject;
using Script.Library;
using Script.TypedElementRuntime;

namespace Script.Engine
{
	[PathName("/Script/Engine.TypedElementPasteOptions")]
	public partial class FTypedElementPasteOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TypedElementPasteOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementPasteOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementPasteOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementPasteOptions A, FTypedElementPasteOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementPasteOptions A, FTypedElementPasteOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementPasteOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UTypedElementSelectionSet SelectionSetToModify
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SelectionSetToModify, __ReturnBuffer);

					return *(UTypedElementSelectionSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SelectionSetToModify, __InBuffer);
				}
			}
		}

		public bool bPasteAtLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPasteAtLocation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPasteAtLocation, __InBuffer);
				}
			}
		}

		public FVector PasteLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PasteLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PasteLocation, __InBuffer);
				}
			}
		}

		private static uint __SelectionSetToModify = 0;

		private static uint __bPasteAtLocation = 0;

		private static uint __PasteLocation = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}