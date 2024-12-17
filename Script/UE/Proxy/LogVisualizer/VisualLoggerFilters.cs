using Script.CoreUObject;
using Script.Library;

namespace Script.LogVisualizer
{
	[PathName("/Script/LogVisualizer.VisualLoggerFilters")]
	public partial class FVisualLoggerFilters : FVisualLoggerFiltersData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LogVisualizer.VisualLoggerFilters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVisualLoggerFilters()
		{
		}

		public static bool operator ==(FVisualLoggerFilters A, FVisualLoggerFilters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVisualLoggerFilters A, FVisualLoggerFilters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVisualLoggerFilters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}