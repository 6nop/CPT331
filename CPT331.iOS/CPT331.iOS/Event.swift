//
//  Event.swift
//  CPT331.iOS
//
//  Created by Peter Weller on 22/09/2016.
//  Copyright © 2016 Peter Weller. All rights reserved.
//

import Foundation
import CoreLocation

class Event:NSObject {
    let id:Int
    var name:String?
    
    // Location
    var address:String?
    var coordinate:CLLocationCoordinate2D?
    
    // Date/time
    var beginDateTime:NSDate?
    var endDateTime:NSDate?
    
    // Url's
    var url:NSURL?
    var thumbnailURL:NSURL?
    var bannerURL:NSURL?
    
    // Category
    private var _subcategory:EventSubcategry?
    var subcategory:EventSubcategry {
        if let s = self._subcategory {
            return s
        } else {
            return .Generic
        }
    }
    var category:EventCategory {
        get {
            return self.subcategory.parentCategory
        }
    }
    
    init(id:Int, name:String?=nil, address:String?=nil, coordinate:CLLocationCoordinate2D?=nil, beginDateTime:NSDate?=nil, endDateTime:NSDate?=nil, url:NSURL?=nil, thumbnailURL:NSURL?=nil, bannerURL:NSURL?=nil, subcategory:EventSubcategry?=nil) {
        self.id = id
        self.name = name
        self.address = address
        self.coordinate = coordinate
        self.beginDateTime = beginDateTime
        self.endDateTime = endDateTime
        self.url = url
        self.thumbnailURL = thumbnailURL
        self.bannerURL = bannerURL
        self._subcategory = subcategory
    }
    
    func update(name name:String?=nil, address:String?=nil, coordinate:CLLocationCoordinate2D?=nil, beginDateTime:NSDate?=nil, endDateTime:NSDate?=nil, url:NSURL?=nil, thumbnailURL:NSURL?=nil, bannerURL:NSURL?=nil, subcategory:EventSubcategry?=nil) {
        
        self.name = name
        self.address = address
        self.coordinate = coordinate
        self.beginDateTime = beginDateTime
        self.endDateTime = endDateTime
        self.url = url
        self.thumbnailURL = thumbnailURL
        self.bannerURL = bannerURL
        self._subcategory = subcategory
    }
}
