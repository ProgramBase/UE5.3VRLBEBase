using Script.CoreUObject;
using Script.Library;

namespace Script.PropertyEditor
{
	[PathName("/Script/PropertyEditor.DetailsSectionSelection")]
	public partial class FDetailsSectionSelection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PropertyEditor.DetailsSectionSelection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDetailsSectionSelection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDetailsSectionSelection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDetailsSectionSelection A, FDetailsSectionSelection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDetailsSectionSelection A, FDetailsSectionSelection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDetailsSectionSelection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<FName> SectionNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionNames, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionNames, __InBuffer);
				}
			}
		}

		private static uint __SectionNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}