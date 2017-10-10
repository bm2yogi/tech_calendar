import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'meetups',
    templateUrl: './meetups.component.html'
})
export class MeetupsComponent {
    public events: MeetupEvent[];
    public lastUpdated: number;

    constructor(http: Http, @Inject('ORIGIN_URL') originUrl: string) {
        this.lastUpdated = Date.now();
        http.get(originUrl + '/api/events').subscribe(result => {
            this.events = result.json() as MeetupEvent[];
        });
    }
}

interface MeetupEvent {
    id: string;
    name: string;
    time: number;
    description: string;
    link: string;
    yes_rsvp_count: number;
    group: Group;
    venue: Venue;
}

interface Group {
    name: string;
}

interface Venue {
    name: string;
    city: string;
}
