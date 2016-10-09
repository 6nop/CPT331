//
//  LocationEventsListCell.swift
//  CPT331.iOS
//
//  Created by Peter Weller on 22/09/2016.
//  Copyright © 2016 Peter Weller. All rights reserved.
//

import UIKit

class EventsListCell: UITableViewCell {
    
    @IBOutlet weak var primaryLabel: UILabel!
    @IBOutlet weak var secondaryLabel: UILabel!
    @IBOutlet weak var thumbnailView: UIImageView!
    
    var event:Event!
    
    override func awakeFromNib() {
        super.awakeFromNib()
    }
    
    func update() {
        self.primaryLabel.text = event.name
        self.secondaryLabel.text = event.subcategory.name
        
        // Rendering mode set so a tint color can be specified
        self.thumbnailView.image = event.subcategory.image?.imageWithRenderingMode(.AlwaysTemplate)
        self.thumbnailView.tintColor = event.category.color
    }
}