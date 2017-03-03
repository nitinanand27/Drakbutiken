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
	/// <summary>Action Box Section</summary>
	[PublishedContentModel("sectionActionBox")]
	public partial class SectionActionBox : PublishedContentModel, IAbstractBackgroundImage, IAbstractlink, IAbstractSectionEffects
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sectionActionBox";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SectionActionBox(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SectionActionBox, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Button text
		///</summary>
		[ImplementPropertyType("buttonText")]
		public string ButtonText
		{
			get { return this.GetPropertyValue<string>("buttonText"); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return this.GetPropertyValue<string>("summary"); }
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

		///<summary>
		/// External Link: Optional link to an external page. External link always opens in a new window. External link OVERRIDES internal link in case it is also set.
		///</summary>
		[ImplementPropertyType("externalLink")]
		public string ExternalLink
		{
			get { return Abstractlink.GetExternalLink(this); }
		}

		///<summary>
		/// Internal Link: Link to a page on your site
		///</summary>
		[ImplementPropertyType("internalLink")]
		public string InternalLink
		{
			get { return Abstractlink.GetInternalLink(this); }
		}

		///<summary>
		/// Animation Direction: Choose the direction from which the animation will start. If you leave this selection empty and animations are enabled, the section will just "fade" in place.
		///</summary>
		[ImplementPropertyType("animationDirection")]
		public object AnimationDirection
		{
			get { return AbstractSectionEffects.GetAnimationDirection(this); }
		}

		///<summary>
		/// Enable Animation: Check this box to make this section animate. You can then specify the exact kind of animation using the options below.
		///</summary>
		[ImplementPropertyType("animationEnable")]
		public bool AnimationEnable
		{
			get { return AbstractSectionEffects.GetAnimationEnable(this); }
		}

		///<summary>
		/// Larger Animation: Check this to amplify the animation effect
		///</summary>
		[ImplementPropertyType("animationLarger")]
		public bool AnimationLarger
		{
			get { return AbstractSectionEffects.GetAnimationLarger(this); }
		}
	}
}
