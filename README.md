HTML5 ASP.NET Web Site
========

## Licenses:
* Modernizr: MIT/BSD license - http://www.modernizr.com/
* jQuery: MIT/GPL license - http://jquery.com/
* H5BP: The Unlicense - https://github.com/paulirish/html5-boilerplate
* normalize css: Public Domain - https://github.com/necolas/normalize.css
* 960 Grid System: MIT/GPL license - http://960.gs/
* Sitemaps.Net: MIT license - http://james.newtonking.com/projects/sitemaps-net.aspx

## Everything else:
* [The Unlicense](http://unlicense.org) (aka: public domain) 


## Summary:
* ASP.Net H5BP ripoff using JQuery, Modernizr, normalize.css, 960 grid system, and Sitemaps.Net.
* The "oldie" conditional <html> class to style for older IE8 and lower. http://bit.ly/jKmkHM 
* ASP.Net website plugin that automatically generates an XML sitemap of your content (based on Web.Sitemap file) 
* Optimized web.config with gzip, rewrite rules targetting .Net Framework 4.0
* Download as a Template ready to be imported into Visual Studio (My Documents\Visual Studio 2010\Templates\ProjectTemplates) folder


## Adjustments and Descriptions:
#### Bin (directory)
* Newtonsoft.Sitemaps.dll: used to create sitemap.xml files from Web.Sitemap file.

#### css (directory)
* style.css: normalize.css, 960 grid, h5bp styles.

#### js (directory)
* jquery-1.7.1.min.js: latest minified version.
* modernizr-2.0.6.min.js: latest minified version using a custom build.

#### apple-touch-icon.png: 
* change this out with your own image or add others images according to Apples specs or mathias recommendations.
* http://developer.apple.com/library/safari/#documentation/appleapplications/reference/safariwebcontent/configuringwebapplications/configuringwebapplications.html
* http://mathiasbynens.be/notes/touch-icons#sizes

#### crossdomain.xml
* http://www.adobe.com/devnet/articles/crossdomain_policy_file_spec.html

#### Error.aspx
* Basic error page example. Use your own or modify to suit.

#### favicon.ico: 
* Self explanatory.

#### Global.asax
* ASP.NET application file.

#### humans.txt: 
* Adjust "team" and other aspects you wish to include OR remove it if you don't believe it to be the cats ass.
* http://humanstxt.org/

#### main.master: 
* Title, Description, and Keywords meta tags will be adjusted on each indivdual descendant page, not here.
* meta author, application-name, viewport get changed here.
* Main content placeholder to for descendant page markup.
* <footer> with self-updating copyright year element and script..use it or lose it.
* The latest JQuery library with local fallback.
* Content placeholder for use by descendant pages to add scripts and keep towards the bottom of the page.
* Google Analytics async script.
* IE6 Chrome Frame install prompt.
* Modify the markup...do your thing boo-boo.

#### robots.txt: 
* Adjust as necessary: http://www.robotstxt.org/
* XML sitemap data is returned by pointing the "Sitemap:" property to "http://yourwebsite.com/sitemap.axd"

#### Web.config: 
* Adjust `<authentication mode="None" />` 
* Change customErrors configuration and Error.aspx page if you have your own preferences.
* Adjust "Rewrite" rules to reflect your preferences.
* Adjust mail settings if sending email from the site.
* Basically, look it over real good and make the changes you need.
	- SessionState/ViewState disabled globally, enable it page-by-page when needed or whatever works for you.

#### Web.sitemap: 
* Hopefully self-explanatory.


## Changelog:
### v0.6 - 11/29/2011
* Update JQuery version to 1.7.1
* Adjust main.master to reflect JQuery version changes
* Update style.css for normalize.css project changes
* Global.asax - Added commented out "Route" for default.aspx routing
* Web.config - Rewrite rules for default document and lower case url's

### v0.5 - 09/04/2011 - Minor Tweaks

### v0.4 - 08/12/2011 - Update for h5bp 2.0 changes.
* Added "oldie" only and modernizr support to the html tag.
* Added dns-prefetch for googleapis.com meta tag.
* Removed loads of unnecessary meta tags from the <head>.
* Replaced html5shim with modernizr custom build.
* Removed ie6msg script with chrome frame install prompt.
* Modified style.css for updated normalize.css and h5pb changes.
* Updated JQuery version to the latest and greatest.
* Removed copyright.js file with inline copyright script within main.master.

### v0.3 - 06/03/2011 - Initial release


## Credits:
* favicon/apple-touch-icon: IconEden | HomePage: http://www.iconeden.com
* Lots of people