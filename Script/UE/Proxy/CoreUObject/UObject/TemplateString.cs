using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TemplateString")]
	public partial class FTemplateString : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.TemplateString");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTemplateString() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTemplateString() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTemplateString A, FTemplateString B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTemplateString A, FTemplateString B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTemplateString;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Template
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Template, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Template, __InBuffer);
				}
			}
		}

		private static uint __Template = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}