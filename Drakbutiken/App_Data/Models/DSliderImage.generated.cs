//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Slider Image</summary>
	[PublishedContentModel("dSliderImage")]
	public partial class DSliderImage : PublishedContentModel, IAbstractBackgroundImage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "dSliderImage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DSliderImage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DSliderImage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Subtitle: If you leave this blank, then the general subtitle will be used instead.
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}

		///<summary>
		/// Title: If you leave this blank, then the general title will be used instead. Please note that the node name IS NOT USED in any case.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return AbstractBackgroundImage.GetImage(this); }
		}

		///<summary>
		/// Use Light Overlay: If you have checked "Use Overlay" above, check this box to use a light overlay. If you leave this box unchecked, a dark overlay will be used.
		///</summary>
		[ImplementPropertyType("useLightOverlay")]
		public bool UseLightOverlay
		{
			get { return AbstractBackgroundImage.GetUseLightOverlay(this); }
		}

		///<summary>
		/// Use Light Text Color: Check to use light color for text. If unchecked, dark color will be used.
		///</summary>
		[ImplementPropertyType("useLightTextColor")]
		public bool UseLightTextColor
		{
			get { return AbstractBackgroundImage.GetUseLightTextColor(this); }
		}

		///<summary>
		/// Use Overlay: If you have set a background image, you can use a dark or light overlay
		///</summary>
		[ImplementPropertyType("useOverlay")]
		public bool UseOverlay
		{
			get { return AbstractBackgroundImage.GetUseOverlay(this); }
		}
	}
}
