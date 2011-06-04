HTML5 ASP.NET Web Site
========

## License:
* html5shiv: MIT license
* jQuery: MIT/GPL license
* HTML5Doctor CSS reset: Public Domain
* CSS Reset Reloaded: Public Domain
* 960 Grid System: MIT/GPL license
* Sitemaps.Net: MIT license
#### Everything else:
* [The Unlicense](http://unlicense.org) (aka: public domain) 


## Summary:
* normalize css: https://github.com/necolas/normalize.css
* jquery: http://jquery.com/
* The 960 grid system by Nathan Smith injected into the "style.css" sheet. http://960.gs/. If you don't use it, remove it.
* The "oldie" conditional <html> class to style older Internet Explorer versions. http://bit.ly/jKmkHM 
* html5 feature detection (minimal). http://code.google.com/p/html5shiv/ 
* Lame IE6 upgrade message, lazy on my part. http://www.ie6nomore.com/ 
* ASP.Net website plugin that automatically generates an XML sitemap of your content (based on Web.Sitemap file) http://james.newtonking.com/projects/sitemaps-net.aspx 


## Modifications you really want to make:
#### humans.txt: 
* adjust "team" and other aspects you wish to include OR remove it if you don't believe it to be the cats ass
* http://humanstxt.org/

#### robots.txt: 
* adjust for any exclusions, etc
* http://www.robotstxt.org/

#### favicon.ico: 
* change this out with your own icon

#### apple-touch-icon.png: 
* change this out with your own image or add others icons according to Apples specs
* http://developer.apple.com/library/safari/#documentation/appleapplications/reference/safariwebcontent/configuringwebapplications/configuringwebapplications.html

#### main.master: 
* Adjust tags in the `<head>` element to reflect information related to the site
* NOTE: (Title, and Description/Keywords meta tags will be changed on individual pages, not the master page)
* meta author
* meta application-name
* meta msapplication-starturl
* meta msapplication-tooltip
* meta geo.region
* meta geo.placename
* meta geo.position
* meta ICBM
* Dublin Core Subject and Description
* link author (adjust the domain name or remove if your not using a humans.txt file)
* html5Shim: Just inside the `</head>` and wrapped in IE conditional comment, swap out for modernizr if you require greater feature detection http://www.modernizr.com/
* ie6Msg: Just after the `<body>` and `<form>` and wrapped in IE conditional comment, splays a large upgrade banner at the top for IE6 users
* Google Analytics: one is for sites with http/https, the other for just http. Or remove...
* Modify markup for your master page...do your thing boo-boo.

#### Web.config: 
* Adjust `<authentication mode="None" />` if necessary
* Change customErrors configuration and Error.aspx page if you have your own preferences
* Adjust "Rewrite" rules to reflect your preferences
* Adjust mail settings if sending email from the site
* Basically, look it over real good and make the changes you need.
	- SessionState/ViewState disabled globally, enable it page-by-page when needed or whatever works for you

#### Web.sitemap: 
* Self-explanatory


## Changelog:
### v0.3 - 06/03/2011 - Initial release


## Credits:
* favicon/apple-touch-icon: IconEden | HomePage: http://www.iconeden.com
* http://html5boilerplate.com/
* http://960.gs/
* http://html5doctor.com/
* http://www.blueprintcss.org/
* http://meyerweb.com/
* http://paulirish.com/
* http://ejohn.org/category/blog/
* http://remysharp.com/
* http://mathiasbynens.be/
* http://twitter.com/#!/jon_neal
* https://github.com/afarkas

tons more....but you get the idea.