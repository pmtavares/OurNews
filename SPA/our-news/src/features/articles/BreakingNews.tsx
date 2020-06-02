import React, {Fragment} from 'react'
import {Grid, Advertisement, Label, List, Image} from 'semantic-ui-react';
import './BreakingNews.css';

const BreakingNews = () => {
    return (
        <Fragment>
                <Grid columns={2} >
                    <Grid.Row>
                        <Grid.Column width={10}>
                            <List  selection >
                                <List.Item>
                                    <a href="#">
                                        <Label horizontal className="breaking-news-label">
                                            Breaking news
                                        </Label>
                                        <span className="breaking-news-data">Breaking news</span>
                                    </a>
                                </List.Item>
                            </List>                            
                        </Grid.Column>
                        <Grid.Column width={6}>
                            <Advertisement unit='banner' test='Head over heels' className="breaking-news-add">
                                <Image src="./assets/images/adds/add1.png" />
                            </Advertisement>
                        </Grid.Column>
                    </Grid.Row>
                </Grid>
        </Fragment>
    )
}

export default BreakingNews
