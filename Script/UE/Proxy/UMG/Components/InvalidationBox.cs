using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.InvalidationBox")]
	public partial class UInvalidationBox : UContentWidget, IStaticClass
	{
		public bool bCanCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanCache, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanCache, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.InvalidationBox");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <note>
		/// the other internal flags can disable the option.
		/// </note>
		public virtual void SetCanCache(bool CanCache)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = CanCache;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCanCache, __InBuffer);
			}
		}

		public virtual void InvalidateCache()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __InvalidateCache);
			}
		}

		/// <returns>
		/// true when the invalidation box cache the widgets.
		/// The widgets will be updated only if they get invalidated.
		/// </returns>
		public virtual bool GetCanCache()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCanCache, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __bCanCache = 0;

		private static uint __SetCanCache = 0;

		private static uint __InvalidateCache = 0;

		private static uint __GetCanCache = 0;
	}
}